namespace GetHardwareInfo
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblSubHeader = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.grpMachineInfo = new System.Windows.Forms.GroupBox();
            this.lblOSValue = new System.Windows.Forms.Label();
            this.lblOS = new System.Windows.Forms.Label();
            this.lblBIOSValue = new System.Windows.Forms.Label();
            this.lblBIOS = new System.Windows.Forms.Label();
            this.lblServiceTagValue = new System.Windows.Forms.Label();
            this.lblServiceTag = new System.Windows.Forms.Label();
            this.lblModelValue = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblManufacturerValue = new System.Windows.Forms.Label();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.grpCPU = new System.Windows.Forms.GroupBox();
            this.lblCPUCores = new System.Windows.Forms.Label();
            this.lblCPUName = new System.Windows.Forms.Label();
            this.grpGPU = new System.Windows.Forms.GroupBox();
            this.lblGPUName = new System.Windows.Forms.Label();
            this.grpRAM = new System.Windows.Forms.GroupBox();
            this.lblRAMFree = new System.Windows.Forms.Label();
            this.pnlRAMList = new System.Windows.Forms.Panel();
            this.grpStorage = new System.Windows.Forms.GroupBox();
            this.pnlStorageList = new System.Windows.Forms.Panel();
            this.lblFooterNote = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.grpMachineInfo.SuspendLayout();
            this.grpCPU.SuspendLayout();
            this.grpGPU.SuspendLayout();
            this.grpRAM.SuspendLayout();
            this.grpStorage.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.pnlHeader.Controls.Add(this.lblSubHeader);
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(800, 60);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblSubHeader
            // 
            this.lblSubHeader.AutoSize = true;
            this.lblSubHeader.ForeColor = System.Drawing.Color.Silver;
            this.lblSubHeader.Location = new System.Drawing.Point(15, 35);
            this.lblSubHeader.Name = "lblSubHeader";
            this.lblSubHeader.Size = new System.Drawing.Size(199, 13);
            this.lblSubHeader.TabIndex = 1;
            this.lblSubHeader.Text = "COMPUTER | User | IP";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(229, 24);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "THÔNG TIN HỆ THỐNG";
            // 
            // grpMachineInfo
            // 
            this.grpMachineInfo.Controls.Add(this.lblOSValue);
            this.grpMachineInfo.Controls.Add(this.lblOS);
            this.grpMachineInfo.Controls.Add(this.lblBIOSValue);
            this.grpMachineInfo.Controls.Add(this.lblBIOS);
            this.grpMachineInfo.Controls.Add(this.lblServiceTagValue);
            this.grpMachineInfo.Controls.Add(this.lblServiceTag);
            this.grpMachineInfo.Controls.Add(this.lblModelValue);
            this.grpMachineInfo.Controls.Add(this.lblModel);
            this.grpMachineInfo.Controls.Add(this.lblManufacturerValue);
            this.grpMachineInfo.Controls.Add(this.lblManufacturer);
            this.grpMachineInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMachineInfo.Location = new System.Drawing.Point(12, 70);
            this.grpMachineInfo.Name = "grpMachineInfo";
            this.grpMachineInfo.Size = new System.Drawing.Size(380, 180);
            this.grpMachineInfo.TabIndex = 1;
            this.grpMachineInfo.TabStop = false;
            this.grpMachineInfo.Text = "Thông tin máy";
            // 
            // lblOSValue
            // 
            this.lblOSValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOSValue.Location = new System.Drawing.Point(90, 120);
            this.lblOSValue.Name = "lblOSValue";
            this.lblOSValue.Size = new System.Drawing.Size(280, 40);
            this.lblOSValue.TabIndex = 9;
            this.lblOSValue.Text = "Windows 10...";
            // 
            // lblOS
            // 
            this.lblOS.AutoSize = true;
            this.lblOS.ForeColor = System.Drawing.Color.DimGray;
            this.lblOS.Location = new System.Drawing.Point(15, 120);
            this.lblOS.Name = "lblOS";
            this.lblOS.Size = new System.Drawing.Size(37, 13);
            this.lblOS.TabIndex = 8;
            this.lblOS.Text = "HĐH:";
            // 
            // lblBIOSValue
            // 
            this.lblBIOSValue.AutoSize = true;
            this.lblBIOSValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBIOSValue.Location = new System.Drawing.Point(90, 95);
            this.lblBIOSValue.Name = "lblBIOSValue";
            this.lblBIOSValue.Size = new System.Drawing.Size(32, 13);
            this.lblBIOSValue.TabIndex = 7;
            this.lblBIOSValue.Text = "BIOS";
            // 
            // lblBIOS
            // 
            this.lblBIOS.AutoSize = true;
            this.lblBIOS.ForeColor = System.Drawing.Color.DimGray;
            this.lblBIOS.Location = new System.Drawing.Point(15, 95);
            this.lblBIOS.Name = "lblBIOS";
            this.lblBIOS.Size = new System.Drawing.Size(40, 13);
            this.lblBIOS.TabIndex = 6;
            this.lblBIOS.Text = "BIOS:";
            // 
            // lblServiceTagValue
            // 
            this.lblServiceTagValue.AutoSize = true;
            this.lblServiceTagValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceTagValue.Location = new System.Drawing.Point(90, 70);
            this.lblServiceTagValue.Name = "lblServiceTagValue";
            this.lblServiceTagValue.Size = new System.Drawing.Size(65, 13);
            this.lblServiceTagValue.TabIndex = 5;
            this.lblServiceTagValue.Text = "Service Tag";
            // 
            // lblServiceTag
            // 
            this.lblServiceTag.AutoSize = true;
            this.lblServiceTag.ForeColor = System.Drawing.Color.DimGray;
            this.lblServiceTag.Location = new System.Drawing.Point(15, 70);
            this.lblServiceTag.Name = "lblServiceTag";
            this.lblServiceTag.Size = new System.Drawing.Size(79, 13);
            this.lblServiceTag.TabIndex = 4;
            this.lblServiceTag.Text = "Service Tag:";
            // 
            // lblModelValue
            // 
            this.lblModelValue.AutoSize = true;
            this.lblModelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelValue.Location = new System.Drawing.Point(90, 45);
            this.lblModelValue.Name = "lblModelValue";
            this.lblModelValue.Size = new System.Drawing.Size(36, 13);
            this.lblModelValue.TabIndex = 3;
            this.lblModelValue.Text = "Model";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.ForeColor = System.Drawing.Color.DimGray;
            this.lblModel.Location = new System.Drawing.Point(15, 45);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(45, 13);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Model:";
            // 
            // lblManufacturerValue
            // 
            this.lblManufacturerValue.AutoSize = true;
            this.lblManufacturerValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManufacturerValue.Location = new System.Drawing.Point(90, 20);
            this.lblManufacturerValue.Name = "lblManufacturerValue";
            this.lblManufacturerValue.Size = new System.Drawing.Size(70, 13);
            this.lblManufacturerValue.TabIndex = 1;
            this.lblManufacturerValue.Text = "Manufacturer";
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.ForeColor = System.Drawing.Color.DimGray;
            this.lblManufacturer.Location = new System.Drawing.Point(15, 20);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(61, 13);
            this.lblManufacturer.TabIndex = 0;
            this.lblManufacturer.Text = "Hãng SX:";
            // 
            // grpCPU
            // 
            this.grpCPU.Controls.Add(this.lblCPUCores);
            this.grpCPU.Controls.Add(this.lblCPUName);
            this.grpCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCPU.Location = new System.Drawing.Point(400, 70);
            this.grpCPU.Name = "grpCPU";
            this.grpCPU.Size = new System.Drawing.Size(380, 80);
            this.grpCPU.TabIndex = 2;
            this.grpCPU.TabStop = false;
            this.grpCPU.Text = "Bộ xử lý (CPU)";
            // 
            // lblCPUCores
            // 
            this.lblCPUCores.AutoSize = true;
            this.lblCPUCores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUCores.ForeColor = System.Drawing.Color.DimGray;
            this.lblCPUCores.Location = new System.Drawing.Point(15, 50);
            this.lblCPUCores.Name = "lblCPUCores";
            this.lblCPUCores.Size = new System.Drawing.Size(86, 13);
            this.lblCPUCores.TabIndex = 1;
            this.lblCPUCores.Text = "2 Nhân / 4 Luồng";
            // 
            // lblCPUName
            // 
            this.lblCPUName.AutoSize = true;
            this.lblCPUName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUName.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblCPUName.Location = new System.Drawing.Point(15, 25);
            this.lblCPUName.Name = "lblCPUName";
            this.lblCPUName.Size = new System.Drawing.Size(67, 13);
            this.lblCPUName.TabIndex = 0;
            this.lblCPUName.Text = "Intel Core...";
            // 
            // grpGPU
            // 
            this.grpGPU.Controls.Add(this.lblGPUName);
            this.grpGPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGPU.Location = new System.Drawing.Point(400, 160);
            this.grpGPU.Name = "grpGPU";
            this.grpGPU.Size = new System.Drawing.Size(380, 90);
            this.grpGPU.TabIndex = 3;
            this.grpGPU.TabStop = false;
            this.grpGPU.Text = "Card đồ họa (GPU)";
            // 
            // lblGPUName
            // 
            this.lblGPUName.AutoSize = true;
            this.lblGPUName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPUName.ForeColor = System.Drawing.Color.DimGray;
            this.lblGPUName.Location = new System.Drawing.Point(15, 30);
            this.lblGPUName.Name = "lblGPUName";
            this.lblGPUName.Size = new System.Drawing.Size(69, 13);
            this.lblGPUName.TabIndex = 0;
            this.lblGPUName.Text = "Intel HD Graphics";
            // 
            // grpRAM
            // 
            this.grpRAM.Controls.Add(this.lblRAMFree);
            this.grpRAM.Controls.Add(this.pnlRAMList);
            this.grpRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRAM.Location = new System.Drawing.Point(12, 260);
            this.grpRAM.Name = "grpRAM";
            this.grpRAM.Size = new System.Drawing.Size(768, 120);
            this.grpRAM.TabIndex = 4;
            this.grpRAM.TabStop = false;
            this.grpRAM.Text = "Bộ nhớ RAM";
            // 
            // lblRAMFree
            // 
            this.lblRAMFree.AutoSize = true;
            this.lblRAMFree.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRAMFree.ForeColor = System.Drawing.Color.Chocolate;
            this.lblRAMFree.Location = new System.Drawing.Point(15, 95);
            this.lblRAMFree.Name = "lblRAMFree";
            this.lblRAMFree.Size = new System.Drawing.Size(200, 13);
            this.lblRAMFree.TabIndex = 1;
            this.lblRAMFree.Text = ">>> Còn trống: 1 khe (có thể nâng cấp)";
            // 
            // pnlRAMList
            // 
            this.pnlRAMList.AutoScroll = true;
            this.pnlRAMList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRAMList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlRAMList.Location = new System.Drawing.Point(15, 20);
            this.pnlRAMList.Name = "pnlRAMList";
            this.pnlRAMList.Size = new System.Drawing.Size(740, 70);
            this.pnlRAMList.TabIndex = 0;
            // 
            // grpStorage
            // 
            this.grpStorage.Controls.Add(this.pnlStorageList);
            this.grpStorage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStorage.Location = new System.Drawing.Point(12, 390);
            this.grpStorage.Name = "grpStorage";
            this.grpStorage.Size = new System.Drawing.Size(768, 100);
            this.grpStorage.TabIndex = 5;
            this.grpStorage.TabStop = false;
            this.grpStorage.Text = "Ổ lưu trữ";
            // 
            // pnlStorageList
            // 
            this.pnlStorageList.AutoScroll = true;
            this.pnlStorageList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStorageList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlStorageList.Location = new System.Drawing.Point(15, 20);
            this.pnlStorageList.Name = "pnlStorageList";
            this.pnlStorageList.Size = new System.Drawing.Size(740, 70);
            this.pnlStorageList.TabIndex = 0;
            // 
            // lblFooterNote
            // 
            this.lblFooterNote.AutoSize = true;
            this.lblFooterNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooterNote.ForeColor = System.Drawing.Color.Gray;
            this.lblFooterNote.Location = new System.Drawing.Point(12, 500);
            this.lblFooterNote.Name = "lblFooterNote";
            this.lblFooterNote.Size = new System.Drawing.Size(270, 13);
            this.lblFooterNote.TabIndex = 6;
            this.lblFooterNote.Text = "* Kiểm tra mainboard/laptop để biết chính xác số khe còn trống";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(280, 520);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(100, 30);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "Xuất File TXT";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(400, 520);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(100, 30);
            this.btnCopy.TabIndex = 8;
            this.btnCopy.Text = "Copy Clipboard";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(520, 520);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 30);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "X Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 570);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.lblFooterNote);
            this.Controls.Add(this.grpStorage);
            this.Controls.Add(this.grpRAM);
            this.Controls.Add(this.grpGPU);
            this.Controls.Add(this.grpCPU);
            this.Controls.Add(this.grpMachineInfo);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin hệ thống";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grpMachineInfo.ResumeLayout(false);
            this.grpMachineInfo.PerformLayout();
            this.grpCPU.ResumeLayout(false);
            this.grpCPU.PerformLayout();
            this.grpGPU.ResumeLayout(false);
            this.grpGPU.PerformLayout();
            this.grpRAM.ResumeLayout(false);
            this.grpRAM.PerformLayout();
            this.grpStorage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblSubHeader;
        private System.Windows.Forms.GroupBox grpMachineInfo;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Label lblManufacturerValue;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblModelValue;
        private System.Windows.Forms.Label lblServiceTag;
        private System.Windows.Forms.Label lblServiceTagValue;
        private System.Windows.Forms.Label lblBIOS;
        private System.Windows.Forms.Label lblBIOSValue;
        private System.Windows.Forms.Label lblOS;
        private System.Windows.Forms.Label lblOSValue;
        private System.Windows.Forms.GroupBox grpCPU;
        private System.Windows.Forms.Label lblCPUName;
        private System.Windows.Forms.Label lblCPUCores;
        private System.Windows.Forms.GroupBox grpGPU;
        private System.Windows.Forms.Label lblGPUName;
        private System.Windows.Forms.GroupBox grpRAM;
        private System.Windows.Forms.Panel pnlRAMList;
        private System.Windows.Forms.Label lblRAMFree;
        private System.Windows.Forms.GroupBox grpStorage;
        private System.Windows.Forms.Panel pnlStorageList;
        private System.Windows.Forms.Label lblFooterNote;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnClose;
    }
}