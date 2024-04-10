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
using System.Reflection;
using System.Drawing;

namespace GetHardwareInfo
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        string computerName;
        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_BIOS");
                foreach (ManagementObject bios in searcher.Get())
                {
                    string serialNumber = bios["SerialNumber"].ToString();
                    richTextBox1.Text = "Serial Number: " + serialNumber + Environment.NewLine;
                }
                computerName = Environment.MachineName;
                richTextBox1.Text += "System Name: " + computerName + Environment.NewLine;

                ManagementObjectSearcher searcher2 = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");
                foreach (ManagementObject computerSystem in searcher2.Get())
                {
                    string computerModel = computerSystem["Model"].ToString();
                    richTextBox1.Text += "Model: " + computerModel + Environment.NewLine;
                    string domainOrWorkgroupName = computerSystem["PartOfDomain"].Equals(true) ? computerSystem["Domain"].ToString() : computerSystem["Workgroup"].ToString();
                    richTextBox1.Text += "Member of: " + domainOrWorkgroupName + Environment.NewLine;
                }




                ManagementObjectSearcher searcher8 = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");
                foreach (ManagementObject computerSystem in searcher8.Get())
                {
                    ulong totalPhysicalMemory = (ulong)computerSystem["TotalPhysicalMemory"];
                    richTextBox1.Text += "Total physical memory: " + FormatSize(totalPhysicalMemory) + Environment.NewLine;

                }
                ManagementClass physicalMemoryClass = new ManagementClass("Win32_PhysicalMemory");
                ManagementObjectCollection physicalMemories = physicalMemoryClass.GetInstances();
                richTextBox1.Text += "Device Locator | Capacity | Speed" + Environment.NewLine;
                foreach (ManagementObject physicalMemory in physicalMemories)
                {
                    ulong ramCapacity = Convert.ToUInt64(physicalMemory["Capacity"]);
                    uint ramSpeed = Convert.ToUInt32(physicalMemory["Speed"]);
                    string ramCapacityString = FormatSize(ramCapacity);
                    string ramSpeedString = FormatSize(ramSpeed);
                    string DeviceLocatorString = physicalMemory["DeviceLocator"].ToString();
                    richTextBox1.Text += DeviceLocatorString + " | " + ramCapacityString + " | " + ramSpeed + Environment.NewLine;
                }



                ManagementObjectSearcher searcher3 = new ManagementObjectSearcher("SELECT * FROM Win32_SystemEnclosure");
                foreach (ManagementObject systemEnclosure in searcher3.Get())
                {
                    string manufacturer = systemEnclosure["Manufacturer"].ToString();
                    richTextBox1.Text += "Manufacturer: " + manufacturer + Environment.NewLine;
                }
                ManagementObjectSearcher searcher4 = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
                foreach (ManagementObject operatingSystem in searcher4.Get())
                {
                    string operatingSystemName = operatingSystem["Caption"].ToString();
                    richTextBox1.Text += "Operating System: " + operatingSystemName + Environment.NewLine;
                    string installDate = operatingSystem["InstallDate"].ToString();
                    string datePart = installDate.Substring(0, 8);
                    DateTime date = DateTime.ParseExact(datePart, "yyyyMMdd", CultureInfo.InvariantCulture);
                    string formattedDate = date.ToString("dd/MM/yyyy");
                    string hourString = installDate.Substring(0, 2);
                    string minuteString = installDate.Substring(2, 2);
                    string secondString = installDate.Substring(4, 2);
                    int hour = int.Parse(hourString);
                    int minute = int.Parse(minuteString);
                    int second = int.Parse(secondString);
                    string formattedTime = $"{hour:00}:{minute:00}:{second:00}";
                    richTextBox1.Text += "Original Install Date: " + formattedDate + " " + formattedTime + Environment.NewLine;
                }
                ManagementObjectSearcher searcher5 = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");

                richTextBox1.Text += "Graphic card name: " + Environment.NewLine;
                richTextBox1.Text += "Name | AdapterRam" + Environment.NewLine;
                foreach (ManagementObject videoController in searcher5.Get())
                {
                    string graphicCardName = videoController["Name"].ToString();
                    ulong videoMemory = Convert.ToUInt64(videoController["AdapterRam"]);

                    string videoMemoryString = FormatSize(videoMemory);
                    //videoController["VideoMemoryType"].ToString();

                    richTextBox1.Text += " + " + graphicCardName + " | " + videoMemoryString + " | " + Environment.NewLine;
                }
                ManagementObjectSearcher searcher6 = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
                foreach (ManagementObject processor in searcher6.Get())
                {
                    string cpuName = processor["Name"].ToString();
                    richTextBox1.Text += $"CPU name: {cpuName}" + Environment.NewLine;
                }
                string systemType = Environment.Is64BitProcess ? "64-bit" : "32-bit";
                richTextBox1.Text += "System Type: " + systemType + Environment.NewLine;

                string installOSDate = Environment.GetEnvironmentVariable("SystemInstalled");



                richTextBox1.Text += new string('-', 97) + Environment.NewLine;
                ManagementObjectSearcher searcher7 = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
                richTextBox1.Text += "List Hard Disk: " + Environment.NewLine;
                richTextBox1.Text += $"Model | Serial | Size" + Environment.NewLine;
                foreach (ManagementObject info in searcher7.Get())
                {
                    string model = info["Model"].ToString();
                    //string Interface = info["InterfaceType"].ToString();
                    string serial = info["SerialNumber"].ToString().Trim();
                    //string mediatype = info["MediaType"].ToString();
                    string size = FormatSize(Convert.ToUInt64(info["Size"])).ToString();
                    richTextBox1.Text += model + " | " + serial + " | " + size + Environment.NewLine;
                }

                ManagementObjectSearcher searcher9 = new ManagementObjectSearcher("SELECT * FROM Win32_LogicalDisk");

                richTextBox1.Text += new string('-', 97) + Environment.NewLine;

                richTextBox1.Text += "Drive | Total Size | Available Space" + Environment.NewLine;
                foreach (ManagementObject queryObj in searcher9.Get())
                {
                    if (queryObj["DriveType"].ToString() == "3")
                    {
                        string driveName = queryObj["Name"].ToString();
                        ulong driveSize = Convert.ToUInt64(queryObj["Size"]);
                        ulong freeSpace = Convert.ToUInt64(queryObj["FreeSpace"]);
                        string totalSize = FormatSize(driveSize);
                        string availableSpace = FormatSize(freeSpace);
                        richTextBox1.Text += driveName + " | " + totalSize + " | " + availableSpace + Environment.NewLine;
                    }

                }

                NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
                NetworkInterface loopbackInterface = interfaces.FirstOrDefault(nic => nic.NetworkInterfaceType == NetworkInterfaceType.Loopback);
                NetworkInterface mainInterface = interfaces.FirstOrDefault(nic => nic != loopbackInterface);

                richTextBox1.Text += new string('-', 97) + Environment.NewLine;
                richTextBox1.Text += "Windows IP Configuration: " + Environment.NewLine;
                IPInterfaceProperties ipProperties = mainInterface.GetIPProperties();

                string output = Regex.Replace(mainInterface.GetPhysicalAddress().ToString(), "(..)", "$1-");
                output = output.TrimEnd('-');

                richTextBox1.Text += "Physical Address: " + output + Environment.NewLine;
                foreach (UnicastIPAddressInformation ip in ipProperties.UnicastAddresses)
                {
                    if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {
                        richTextBox1.Text += "IPv4 Address: " + ip.Address.ToString() + Environment.NewLine;
                        richTextBox1.Text += "Subnet Mask: " + ip.IPv4Mask.ToString() + Environment.NewLine;

                    }
                }
                foreach (GatewayIPAddressInformation gateway in ipProperties.GatewayAddresses)
                {
                    richTextBox1.Text += "Default Gateway: " + gateway.Address.ToString() + Environment.NewLine;
                }

                var dnsAddresses = ipProperties.DnsAddresses;
                richTextBox1.Text += "DNS address: " + Environment.NewLine;
                // Display the DNS addresses for the network interface.
                foreach (IPAddress dnsAddress in dnsAddresses)
                {
                    richTextBox1.Text += " + " + dnsAddress + Environment.NewLine;
                }
                File.WriteAllText(Path.Combine(Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath), computerName + ".txt"), richTextBox1.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
        private void button1_Click(object sender, EventArgs e)
        {

            ProcessStartInfo processStartInfo = new ProcessStartInfo();
            processStartInfo.FileName = "explorer.exe";
            processStartInfo.Arguments = @"/select," + computerName + ".txt";
            Process.Start(processStartInfo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Focus();
            richTextBox1.SelectAll();
            richTextBox1.Copy();
        }
    }
}