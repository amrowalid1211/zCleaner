using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zCleaner;

namespace ZThermalManager.SCREENS
{
    public partial class admin : UserControl
    {
        public admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!=null && textBox2!=null)
            {
                Form1.memory.username = textBox1.Text;
                Form1.memory.password = textBox2.Text;
                Memory.saveSettings();
            }
        }
        public void updateScreen()
        {
            textBox1.Text = Form1.memory.username;
            textBox2.Text = Form1.memory.password;
        }
    }
}
