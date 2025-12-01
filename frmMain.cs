using System;
using System.Management;
using System.Windows.Forms;
using System.Globalization;
using System.Diagnostics;
using System.IO;
using System.Net.NetworkInformation;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Text;
using System.Collections.Generic;

namespace GetHardwareInfo
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private string computerName;
        private string userName;
        private string ipAddress;

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                // Header Info
                computerName = Environment.MachineName;
                userName = Environment.UserName;
                ipAddress = GetLocalIPAddress();
                lblSubHeader.Text = $"{computerName} | {userName} | {ipAddress}";

                // Machine Info
                GetMachineInfo();

                // CPU
                GetCPUInfo();

                // GPU
                GetGPUInfo();

                // RAM
                GetRAMInfo();

                // Storage
                GetStorageInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading info: " + ex.Message);
            }
        }

        private string GetLocalIPAddress()
        {
            try
            {
                NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
                NetworkInterface mainInterface = interfaces.FirstOrDefault(nic => 
                    nic.NetworkInterfaceType != NetworkInterfaceType.Loopback && 
                    nic.OperationalStatus == OperationalStatus.Up &&
                    (nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet || nic.NetworkInterfaceType == NetworkInterfaceType.Wireless80211));

                if (mainInterface != null)
                {
                    IPInterfaceProperties ipProperties = mainInterface.GetIPProperties();
                    foreach (UnicastIPAddressInformation ip in ipProperties.UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        {
                            return ip.Address.ToString();
                        }
                    }
                }
            }
            catch { }
            return "N/A";
        }

        private void GetMachineInfo()
        {
            // Manufacturer & Model
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");
            foreach (ManagementObject obj in searcher.Get())
            {
                lblManufacturerValue.Text = obj["Manufacturer"].ToString();
                lblModelValue.Text = obj["Model"].ToString();
            }

            // BIOS & Serial (Service Tag)
            searcher = new ManagementObjectSearcher("SELECT * FROM Win32_BIOS");
            foreach (ManagementObject obj in searcher.Get())
            {
                lblServiceTagValue.Text = obj["SerialNumber"].ToString();
                lblBIOSValue.Text = obj["Manufacturer"].ToString() + " " + obj["SMBIOSBIOSVersion"].ToString();
            }

            // OS
            searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
            foreach (ManagementObject obj in searcher.Get())
            {
                lblOSValue.Text = obj["Caption"].ToString() + " - Build " + obj["BuildNumber"].ToString();
            }
        }

        private void GetCPUInfo()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
            foreach (ManagementObject obj in searcher.Get())
            {
                lblCPUName.Text = obj["Name"].ToString();
                lblCPUCores.Text = $"{obj["NumberOfCores"]} Nhân / {obj["NumberOfLogicalProcessors"]} Luồng";
            }
        }

        private void GetGPUInfo()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
            foreach (ManagementObject obj in searcher.Get())
            {
                string name = obj["Name"].ToString();
                ulong ram = 0;
                try { ram = Convert.ToUInt64(obj["AdapterRam"]); } catch { }
                
                lblGPUName.Text = $"{name} ({FormatSize(ram)})";
                // Only get the first one for simplicity or append if multiple
                break; 
            }
        }

        private void GetRAMInfo()
        {
            // Total RAM
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");
            ulong totalRam = 0;
            foreach (ManagementObject obj in searcher.Get())
            {
                totalRam = Convert.ToUInt64(obj["TotalPhysicalMemory"]);
            }

            // RAM Slots
            ManagementObjectSearcher memSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory");
            int stickCount = 0;
            int yPos = 0;
            pnlRAMList.Controls.Clear();

            foreach (ManagementObject obj in memSearcher.Get())
            {
                stickCount++;
                ulong capacity = Convert.ToUInt64(obj["Capacity"]);
                uint speed = Convert.ToUInt32(obj["Speed"]);
                string devLocator = obj["DeviceLocator"].ToString();
                string manufacturer = obj["Manufacturer"].ToString();

                Label lbl = new Label();
                lbl.Text = $"{devLocator}: {FormatSize(capacity)} @ {speed} MHz - {manufacturer}";
                lbl.AutoSize = true;
                lbl.Location = new Point(0, yPos);
                lbl.ForeColor = Color.Green;
                pnlRAMList.Controls.Add(lbl);
                yPos += 20;
            }

            // Max Slots (to calculate free)
            int maxSlots = 0;
            try
            {
                // Try Win32_MemoryDevice first as it often represents physical slots more accurately
                ManagementObjectSearcher slotSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_MemoryDevice");
                maxSlots = slotSearcher.Get().Count;

                // If 0 or unreasonable, fallback to PhysicalMemoryArray
                if (maxSlots == 0)
                {
                    ManagementObjectSearcher arraySearcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemoryArray");
                    foreach (ManagementObject obj in arraySearcher.Get())
                    {
                        maxSlots = Convert.ToInt32(obj["MemoryDevices"]);
                    }
                }
            }
            catch { maxSlots = stickCount; } // Fallback

            // Ensure maxSlots is at least stickCount
            if (maxSlots < stickCount) maxSlots = stickCount;

            grpRAM.Text = $"Bộ nhớ RAM - Tổng: {FormatSize(totalRam)} ({stickCount}/{maxSlots} khe)";
            
            int freeSlots = maxSlots - stickCount;
            if (freeSlots > 0)
                lblRAMFree.Text = $">>> Còn trống: {freeSlots} khe (có thể nâng cấp thêm RAM)";
            else
                lblRAMFree.Text = ">>> Đã sử dụng hết các khe RAM (Chỉ có thể nâng cấp dung lượng)";
        }

        private void GetStorageInfo()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
            int count = 0;
            int yPos = 0;
            pnlStorageList.Controls.Clear();

            foreach (ManagementObject obj in searcher.Get())
            {
                count++;
                string model = obj["Model"].ToString();
                string serial = obj["SerialNumber"].ToString().Trim();
                ulong size = Convert.ToUInt64(obj["Size"]);

                Label lbl = new Label();
                lbl.Text = $"{model} - {serial} - {FormatSize(size)}";
                lbl.AutoSize = true;
                lbl.Location = new Point(0, yPos);
                pnlStorageList.Controls.Add(lbl);
                yPos += 20;
            }
            grpStorage.Text = $"Ổ lưu trữ ({count} ổ)";
        }

        private string FormatSize(ulong size)
        {
            string[] suffixes = { "B", "KB", "MB", "GB", "TB" };
            int suffixIndex = 0;
            double formattedSize = size;

            while (formattedSize >= 1024 && suffixIndex < suffixes.Length - 1)
            {
                formattedSize /= 1024;
                suffixIndex++;
            }

            return $"{formattedSize:N2} {suffixes[suffixIndex]}";
        }

        private string GenerateReport()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("THÔNG TIN HỆ THỐNG");
            sb.AppendLine("--------------------------------------------------");
            sb.AppendLine($"Computer: {computerName} | User: {userName} | IP: {ipAddress}");
            sb.AppendLine("");
            sb.AppendLine("[Thông tin máy]");
            sb.AppendLine($"Hãng SX: {lblManufacturerValue.Text}");
            sb.AppendLine($"Model: {lblModelValue.Text}");
            sb.AppendLine($"Service Tag: {lblServiceTagValue.Text}");
            sb.AppendLine($"BIOS: {lblBIOSValue.Text}");
            sb.AppendLine($"HĐH: {lblOSValue.Text}");
            sb.AppendLine("");
            sb.AppendLine("[Bộ xử lý (CPU)]");
            sb.AppendLine($"{lblCPUName.Text}");
            sb.AppendLine($"{lblCPUCores.Text}");
            sb.AppendLine("");
            sb.AppendLine("[Card đồ họa (GPU)]");
            sb.AppendLine($"{lblGPUName.Text}");
            sb.AppendLine("");
            sb.AppendLine($"[{grpRAM.Text}]");
            foreach (Control c in pnlRAMList.Controls)
            {
                sb.AppendLine(c.Text);
            }
            sb.AppendLine(lblRAMFree.Text);
            sb.AppendLine("");
            sb.AppendLine($"[{grpStorage.Text}]");
            foreach (Control c in pnlStorageList.Controls)
            {
                sb.AppendLine(c.Text);
            }
            
            return sb.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string report = GenerateReport();
                string filePath = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), computerName + ".txt");
                File.WriteAllText(filePath, report);
                
                ProcessStartInfo processStartInfo = new ProcessStartInfo();
                processStartInfo.FileName = "explorer.exe";
                processStartInfo.Arguments = @"/select," + filePath;
                Process.Start(processStartInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting file: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string report = GenerateReport();
            Clipboard.SetText(report);
            MessageBox.Show("Đã copy thông tin vào Clipboard!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}