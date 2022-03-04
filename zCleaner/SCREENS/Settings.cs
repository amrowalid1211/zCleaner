using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace zCleaner.SCREENS
{
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           
          //  Memory.LoadSettings();
        }

    

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBox1.Checked)
            //{

            //    Form1.memory.EnableArchive = true;
               
            //}
            //else
            //{
            //    Form1.memory.EnableArchive = false;
            //}
            //Form1.main.addFolder1.updateScreen();
            //Memory.saveSettings();
        }
    }
}
