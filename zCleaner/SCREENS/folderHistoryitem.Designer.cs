namespace zCleaner.SCREENS
{
    partial class folderHistoryitem
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
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblArchivedFiles = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pbDeletedFiles = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblDeletedFiles = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblFolderPath = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblFolderName = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlContainer.SuspendLayout();
            this.itemsContainer.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeletedFiles)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlContainer.Controls.Add(this.itemsContainer);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContainer.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Padding = new System.Windows.Forms.Padding(12);
            this.pnlContainer.Size = new System.Drawing.Size(766, 95);
            this.pnlContainer.TabIndex = 2;
            this.pnlContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContainer_Paint);
            // 
            // itemsContainer
            // 
            this.itemsContainer.BackColor = System.Drawing.Color.Gainsboro;
            this.itemsContainer.Controls.Add(this.panel9);
            this.itemsContainer.Controls.Add(this.pictureBox3);
            this.itemsContainer.Controls.Add(this.pbDeletedFiles);
            this.itemsContainer.Controls.Add(this.panel8);
            this.itemsContainer.Controls.Add(this.panel3);
            this.itemsContainer.Controls.Add(this.panel14);
            this.itemsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsContainer.Location = new System.Drawing.Point(12, 12);
            this.itemsContainer.Name = "itemsContainer";
            this.itemsContainer.Size = new System.Drawing.Size(742, 71);
            this.itemsContainer.TabIndex = 0;
            this.itemsContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.itemsContainer_Paint);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.Controls.Add(this.lblArchivedFiles);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(520, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(10, 71);
            this.panel9.TabIndex = 5;
            // 
            // lblArchivedFiles
            // 
            this.lblArchivedFiles.AutoSize = true;
            this.lblArchivedFiles.BackColor = System.Drawing.Color.White;
            this.lblArchivedFiles.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchivedFiles.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblArchivedFiles.Location = new System.Drawing.Point(6, 23);
            this.lblArchivedFiles.Name = "lblArchivedFiles";
            this.lblArchivedFiles.Size = new System.Drawing.Size(60, 24);
            this.lblArchivedFiles.TabIndex = 1;
            this.lblArchivedFiles.Text = "12343";
            this.lblArchivedFiles.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::ZThermalManager.Properties.Resources.files_and_folders;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox3.Location = new System.Drawing.Point(530, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 71);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pbDeletedFiles
            // 
            this.pbDeletedFiles.BackgroundImage = global::ZThermalManager.Properties.Resources.pngwing_com;
            this.pbDeletedFiles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbDeletedFiles.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbDeletedFiles.Location = new System.Drawing.Point(540, 0);
            this.pbDeletedFiles.Name = "pbDeletedFiles";
            this.pbDeletedFiles.Size = new System.Drawing.Size(42, 71);
            this.pbDeletedFiles.TabIndex = 6;
            this.pbDeletedFiles.TabStop = false;
            this.pbDeletedFiles.Visible = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Controls.Add(this.lblDeletedFiles);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(582, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(160, 71);
            this.panel8.TabIndex = 3;
            // 
            // lblDeletedFiles
            // 
            this.lblDeletedFiles.AutoSize = true;
            this.lblDeletedFiles.BackColor = System.Drawing.Color.White;
            this.lblDeletedFiles.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeletedFiles.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDeletedFiles.Location = new System.Drawing.Point(6, 23);
            this.lblDeletedFiles.Name = "lblDeletedFiles";
            this.lblDeletedFiles.Size = new System.Drawing.Size(72, 24);
            this.lblDeletedFiles.TabIndex = 0;
            this.lblDeletedFiles.Text = "574324";
            this.lblDeletedFiles.Visible = false;
            this.lblDeletedFiles.Click += new System.EventHandler(this.lblDeletedFiles_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(55, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(687, 71);
            this.panel3.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblFolderPath);
            this.panel6.Location = new System.Drawing.Point(0, 42);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(473, 25);
            this.panel6.TabIndex = 1;
            // 
            // lblFolderPath
            // 
            this.lblFolderPath.AutoSize = true;
            this.lblFolderPath.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolderPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(69)))));
            this.lblFolderPath.Location = new System.Drawing.Point(6, 2);
            this.lblFolderPath.Name = "lblFolderPath";
            this.lblFolderPath.Size = new System.Drawing.Size(523, 18);
            this.lblFolderPath.TabIndex = 3;
            this.lblFolderPath.Text = "D:\\Freelance\\satish kumar\\VPAES-C#\\VPAES\\VPAES\\bin\\x64\\Debug\\sadasd";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblFolderName);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(687, 41);
            this.panel5.TabIndex = 0;
            // 
            // lblFolderName
            // 
            this.lblFolderName.AutoSize = true;
            this.lblFolderName.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolderName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(69)))));
            this.lblFolderName.Location = new System.Drawing.Point(3, 8);
            this.lblFolderName.Name = "lblFolderName";
            this.lblFolderName.Size = new System.Drawing.Size(101, 29);
            this.lblFolderName.TabIndex = 0;
            this.lblFolderName.Text = "Desktop";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Transparent;
            this.panel14.Controls.Add(this.pictureBox1);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel14.Location = new System.Drawing.Point(0, 0);
            this.panel14.Name = "panel14";
            this.panel14.Padding = new System.Windows.Forms.Padding(12);
            this.panel14.Size = new System.Drawing.Size(55, 71);
            this.panel14.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ZThermalManager.Properties.Resources.icons8_folder_48;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // folderHistoryitem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlContainer);
            this.Name = "folderHistoryitem";
            this.Size = new System.Drawing.Size(766, 93);
            this.pnlContainer.ResumeLayout(false);
            this.itemsContainer.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeletedFiles)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnlContainer;
        public System.Windows.Forms.Panel itemsContainer;
        public System.Windows.Forms.Panel panel9;
        public System.Windows.Forms.Panel panel8;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.Panel panel14;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.Label lblFolderPath;
        public System.Windows.Forms.Label lblFolderName;
        public System.Windows.Forms.Label lblArchivedFiles;
        public System.Windows.Forms.Label lblDeletedFiles;
        public System.Windows.Forms.PictureBox pbDeletedFiles;
    }
}
