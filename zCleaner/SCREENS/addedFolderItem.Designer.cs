namespace zCleaner.SCREENS
{
    partial class addedFolderItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.itemsContainer = new System.Windows.Forms.Panel();
            this.rdArchive = new System.Windows.Forms.CheckBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.rdBin = new System.Windows.Forms.CheckBox();
            this.bin = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.archive = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.olderThanDateTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.FolderPath = new System.Windows.Forms.Label();
            this.FolderName = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlContainer.SuspendLayout();
            this.itemsContainer.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.archive)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlContainer.Controls.Add(this.itemsContainer);
            this.pnlContainer.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.pnlContainer.Size = new System.Drawing.Size(648, 80);
            this.pnlContainer.TabIndex = 3;
            this.pnlContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContainer_Paint);
            // 
            // itemsContainer
            // 
            this.itemsContainer.BackColor = System.Drawing.Color.Gainsboro;
            this.itemsContainer.Controls.Add(this.rdArchive);
            this.itemsContainer.Controls.Add(this.panel12);
            this.itemsContainer.Controls.Add(this.archive);
            this.itemsContainer.Controls.Add(this.panel8);
            this.itemsContainer.Controls.Add(this.panel3);
            this.itemsContainer.Controls.Add(this.panel14);
            this.itemsContainer.Location = new System.Drawing.Point(9, 10);
            this.itemsContainer.Margin = new System.Windows.Forms.Padding(2);
            this.itemsContainer.Name = "itemsContainer";
            this.itemsContainer.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.itemsContainer.Size = new System.Drawing.Size(628, 64);
            this.itemsContainer.TabIndex = 0;
            // 
            // rdArchive
            // 
            this.rdArchive.AutoSize = true;
            this.rdArchive.Location = new System.Drawing.Point(784, 17);
            this.rdArchive.Margin = new System.Windows.Forms.Padding(2);
            this.rdArchive.Name = "rdArchive";
            this.rdArchive.Size = new System.Drawing.Size(15, 14);
            this.rdArchive.TabIndex = 12;
            this.rdArchive.UseVisualStyleBackColor = true;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Transparent;
            this.panel12.Controls.Add(this.btnDelete);
            this.panel12.Controls.Add(this.rdBin);
            this.panel12.Controls.Add(this.bin);
            this.panel12.Controls.Add(this.label1);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel12.Location = new System.Drawing.Point(488, 4);
            this.panel12.Margin = new System.Windows.Forms.Padding(2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(137, 60);
            this.panel12.TabIndex = 8;
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::ZThermalManager.Properties.Resources.close_icon__1_;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDelete.Location = new System.Drawing.Point(92, 16);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(34, 33);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.TabStop = false;
            // 
            // rdBin
            // 
            this.rdBin.AutoSize = true;
            this.rdBin.Location = new System.Drawing.Point(49, 28);
            this.rdBin.Margin = new System.Windows.Forms.Padding(2);
            this.rdBin.Name = "rdBin";
            this.rdBin.Size = new System.Drawing.Size(15, 14);
            this.rdBin.TabIndex = 11;
            this.rdBin.UseVisualStyleBackColor = true;
            this.rdBin.Visible = false;
            // 
            // bin
            // 
            this.bin.BackgroundImage = global::ZThermalManager.Properties.Resources.pngwing_com;
            this.bin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bin.Location = new System.Drawing.Point(4, 15);
            this.bin.Margin = new System.Windows.Forms.Padding(2);
            this.bin.Name = "bin";
            this.bin.Size = new System.Drawing.Size(40, 35);
            this.bin.TabIndex = 3;
            this.bin.TabStop = false;
            this.bin.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(-509, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desktop";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // archive
            // 
            this.archive.BackgroundImage = global::ZThermalManager.Properties.Resources.files_and_folders;
            this.archive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.archive.Location = new System.Drawing.Point(731, 12);
            this.archive.Margin = new System.Windows.Forms.Padding(2);
            this.archive.Name = "archive";
            this.archive.Size = new System.Drawing.Size(40, 35);
            this.archive.TabIndex = 4;
            this.archive.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Controls.Add(this.olderThanDateTime);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Controls.Add(this.label3);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.ForeColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(394, 4);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(94, 60);
            this.panel8.TabIndex = 3;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // olderThanDateTime
            // 
            this.olderThanDateTime.CustomFormat = "HH:mm:ss";
            this.olderThanDateTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olderThanDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.olderThanDateTime.Location = new System.Drawing.Point(8, 20);
            this.olderThanDateTime.Margin = new System.Windows.Forms.Padding(2);
            this.olderThanDateTime.Name = "olderThanDateTime";
            this.olderThanDateTime.ShowUpDown = true;
            this.olderThanDateTime.Size = new System.Drawing.Size(82, 26);
            this.olderThanDateTime.TabIndex = 7;
            this.olderThanDateTime.Value = new System.DateTime(2020, 2, 25, 0, 0, 0, 0);
            this.olderThanDateTime.ValueChanged += new System.EventHandler(this.olderThanDateTime_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(69)))));
            this.label4.Location = new System.Drawing.Point(14, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "DD:HH::MM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(69)))));
            this.label3.Location = new System.Drawing.Point(7, 1);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Older Than";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(54, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(340, 60);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.FolderPath);
            this.panel5.Controls.Add(this.FolderName);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(340, 54);
            this.panel5.TabIndex = 0;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // FolderPath
            // 
            this.FolderPath.AutoSize = true;
            this.FolderPath.BackColor = System.Drawing.Color.Transparent;
            this.FolderPath.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FolderPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(69)))));
            this.FolderPath.Location = new System.Drawing.Point(5, 36);
            this.FolderPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FolderPath.Name = "FolderPath";
            this.FolderPath.Size = new System.Drawing.Size(415, 14);
            this.FolderPath.TabIndex = 3;
            this.FolderPath.Text = "D:\\Freelance\\satish kumar\\VPAES-C#\\VPAES\\VPAES\\bin\\x64\\Debug\\sadasd";
            this.FolderPath.Click += new System.EventHandler(this.FolderPath_Click);
            // 
            // FolderName
            // 
            this.FolderName.AutoSize = true;
            this.FolderName.BackColor = System.Drawing.Color.Transparent;
            this.FolderName.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FolderName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(69)))));
            this.FolderName.Location = new System.Drawing.Point(4, 7);
            this.FolderName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FolderName.Name = "FolderName";
            this.FolderName.Size = new System.Drawing.Size(78, 23);
            this.FolderName.TabIndex = 0;
            this.FolderName.Text = "Desktop";
            this.FolderName.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Transparent;
            this.panel14.Controls.Add(this.pictureBox1);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel14.Location = new System.Drawing.Point(0, 4);
            this.panel14.Margin = new System.Windows.Forms.Padding(2);
            this.panel14.Name = "panel14";
            this.panel14.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.panel14.Size = new System.Drawing.Size(54, 60);
            this.panel14.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ZThermalManager.Properties.Resources.icons8_folder_48;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(11, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // addedFolderItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlContainer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "addedFolderItem";
            this.Size = new System.Drawing.Size(665, 82);
            this.pnlContainer.ResumeLayout(false);
            this.itemsContainer.ResumeLayout(false);
            this.itemsContainer.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.archive)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnlContainer;
        public System.Windows.Forms.Panel itemsContainer;
        public System.Windows.Forms.Panel panel12;
        public System.Windows.Forms.Panel panel8;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.Panel panel14;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label FolderPath;
        public System.Windows.Forms.Label FolderName;
        public System.Windows.Forms.PictureBox archive;
        public System.Windows.Forms.CheckBox rdBin;
        public System.Windows.Forms.CheckBox rdArchive;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.PictureBox bin;
        public System.Windows.Forms.PictureBox btnDelete;
        public System.Windows.Forms.DateTimePicker olderThanDateTime;
        public System.Windows.Forms.Label label4;
    }
}
