using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace zCleaner.SCREENS
{
    public partial class AddFolder : UserControl
    {
        public AddFolder()
        {
            InitializeComponent();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        List<addedFolderItem> afs;
        public void updateScreen()
        {
            panel1.Controls.Clear();
            afs = new List<addedFolderItem>();
            foreach(var x in Form1.memory.directoryToScans)
            {
                addedFolderItem afi = new addedFolderItem();
                afi.FolderName.Text = Path.GetFileName(x.path);
                afi.FolderPath.Text = x.path;
                afi.olderThanDateTime.Tag = x;
                afi.olderThanDateTime.Value = x.RequiredDate;
                afi.olderThanDateTime.ValueChanged += Olderthan_ValueChanged;
                afi.rdArchive.CheckedChanged += RdArchive_CheckedChanged;
                afi.rdBin.CheckedChanged += RdBin_CheckedChanged;
                afi.rdArchive.Tag = x;
                afi.rdArchive.Checked = x.archiveFiles;
                afi.rdBin.Tag = x;
                afi.rdBin.Checked = x.deleteFiles;
                afs.Add(afi);
                afi.Dock = DockStyle.Top;
                afi.btnDelete.Tag = x;
                afi.btnDelete.Click += Afi_Click;
                if (!Form1.memory.EnableArchive)
                {
                    afi.rdArchive.Hide();
                    afi.archive.Visible = false;
                }
                panel1.Controls.Add(afi);
            }
        }

        private void RdBin_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox s = (CheckBox)sender;
            Console.WriteLine(s.Tag);
            DirectoryToScan dts = (DirectoryToScan)s.Tag;
            dts.deleteFiles = s.Checked;
      
            Memory.saveSettings();
        }

        private void Afi_Click(object sender, EventArgs e)
        {
            PictureBox s = (PictureBox)sender;
            Console.WriteLine(s.Tag);
            DirectoryToScan dts = (DirectoryToScan)s.Tag;
            Form1.memory.directoryToScans.Remove(dts);
            Memory.saveSettings();
            updateScreen();
        }

        private void RdArchive_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox s = (CheckBox)sender;
            Console.WriteLine(s.Tag);
            DirectoryToScan dts = (DirectoryToScan)s.Tag;
            dts.archiveFiles = s.Checked;
       
            Memory.saveSettings();
        }

        private void Olderthan_ValueChanged(object sender, EventArgs e)
        {
            return;
            //No more autosave :(
            DateTimePicker s = (DateTimePicker)sender;
            Console.WriteLine(s.Tag);
            DirectoryToScan dts = (DirectoryToScan) s.Tag;
            dts.RequiredDate =  s.Value;
            Memory.saveSettings();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddFolder_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Memory.AddFolder(fbd.SelectedPath, DefaultValues.includeSubDirectoriesDefault, DefaultValues.defaultAction);
                }
            }
            updateScreen();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            foreach(var x in afs)
            {
                DateTimePicker s = x.olderThanDateTime;
                Console.WriteLine(s.Tag);
                DirectoryToScan dts = (DirectoryToScan)s.Tag;
                dts.RequiredDate = s.Value;
            }
            Memory.saveSettings();
        }
    }
}
