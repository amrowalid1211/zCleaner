using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace zCleaner.SCREENS
{
    public partial class homeScreen : UserControl
    {
        public static bool initialized = false;
        public homeScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Scheduler.scanFolder();
            MessageBox.Show("files have been successfully deleted from the folder(s)");
        }

        public static void updateScreen()
        {
            
        }
        public void updateGUI()
        {
            try
            {
                //   numericUpDown1.Value = Form1.memory.ScanTimeHours;
                //   numericUpDown2.Value = Form1.memory.ScanTimeMinutes;
                //                checkBox1.Checked = Form1.memory.EnableArchive;
                dateTimePicker1.Value = Form1.memory.scanTime;
                initialized = true;
            }
            catch
            {

            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (initialized)
            {
         //       if (numericUpDown1.Value == 0 && numericUpDown2.Value == 0)
        //            numericUpDown2.Value = 1;

         //       Form1.memory.ScanTimeHours = (int)numericUpDown1.Value;
         //       Form1.memory.ScanTimeMinutes = (int)numericUpDown2.Value;
                Form1.main.scheduler.nextScan.Interval = Form1.memory.ScanTimeHours * 3600000 + Form1.memory.ScanTimeMinutes * 60000;
                Memory.saveSettings();
            }
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (initialized)
            {
           //     if (numericUpDown1.Value == 0 && numericUpDown2.Value == 0)
            //        numericUpDown2.Value = 1;

            //    Form1.memory.ScanTimeHours = (int)numericUpDown1.Value;
//Form1.memory.ScanTimeMinutes = (int)numericUpDown2.Value;
             //   Form1.main.scheduler.nextScan.Interval = Form1.memory.ScanTimeHours * 3600000 + Form1.memory.ScanTimeMinutes * 60000;
            //    Memory.saveSettings();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
          
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.Hour == 0 && dateTimePicker1.Value.Minute == 0)
            {
                dateTimePicker1.Value = new DateTime(2020, 1, 1, 0, 1, 0);
            }
            Form1.memory.scanTime = dateTimePicker1.Value;
            Form1.main.scheduler.nextScan.Interval = Form1.memory.scanTime.Hour * 3600000 + Form1.memory.scanTime.Minute * 60000;
            Memory.saveSettings();
        }
    }
}
