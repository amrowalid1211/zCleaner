using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security.Principal;
using System.Text;
using System.Threading;

using System.Windows.Forms;
using ZThermalManager.Properties;
using zCleaner.SCREENS;
using MessageBox = System.Windows.Forms.MessageBox;
using System.Net;
using System.Security;
using System.Linq;

namespace zCleaner
{
    public partial class Form1 : Form
    {
        public static Memory memory;
        public static Form1 main;
        public Scheduler scheduler;
   //    NotifyIcon mynotifyicon;
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            main = this;
            CheckForIllegalCrossThreadCalls = false;
        }

        public Form1(int runs)
        {
            Form1.runs = runs;
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            main = this;
        }

        bool contextExit = false;
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            if (!contextExit)
                e.Cancel = true;
            else mynotifyicon.Visible = false;
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Run1();
            //checkIfAnotherInstanceRunning();
            Memory.LoadSettings();
            Utilities.addToStartUp();
           // mynotifyicon = new NotifyIcon();
         //   mynotifyicon.Click += Mynotifyicon_Click;
            this.Resize += Form1_Resize;
           
            scheduler = new Scheduler();
            scheduler.initializeTimer();
            Scheduler.initializeProcessTimer();
            //   this.button1.BackColor = Color.WhiteSmoke;
            addFolder1.updateScreen();
            updateHomeScreen();
            homeScreen1.updateGUI();
            processesList.updateScreen();
            tab.Top = button1.Top;
        }
        private static Mutex _mutex = null;
        protected void checkIfAnotherInstanceRunning()
        {
            const string appName = "thermalManager";
            bool createdNew;

            _mutex = new Mutex(true, appName, out createdNew);

            if (!createdNew)
            {
                MessageBox.Show("Another instance is already running");
                //app is already running! Exiting the application  
                Form1.main.contextExit = true;
                Application.Exit();
            }

        }
        private void Mynotifyicon_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                //      mynotifyicon.Visible = tr;
                
                this.Hide();
                updateScreens();
            }

            else if (FormWindowState.Normal == this.WindowState)
            {
               // mynotifyicon.Visible = false;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void homeScreen1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        List<folderHistoryitem> afs;
        public void updateHomeScreen()
        {
            homeScreen1.panel1.Controls.Clear();
            afs = new List<folderHistoryitem>();
            foreach (var xDts in Form1.memory.directoryToScans)
            {
                folderHistoryitem fd = new folderHistoryitem();
                fd.lblFolderName.Text = Path.GetFileName(xDts.path);
                fd.lblFolderPath.Text = xDts.path;
                fd.lblDeletedFiles.Text = xDts.filesDeleted + "";
                fd.lblArchivedFiles.Text = xDts.filesZipped + "";
                afs.Add(fd);
                homeScreen1.panel1.Controls.Add(fd);
                fd.Dock = DockStyle.Top;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            updateScreens();
            //    this.button2.BackColor = Color.WhiteSmoke;
            tab.Top = button2.Top;
         //   this.button3.BackColor = Color.Transparent;
            this.button1.BackColor = Color.Transparent;
            addFolder1.BringToFront();
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //    this.button3.BackColor = Color.WhiteSmoke;
       //     tab.Top = button3.Top;
            this.button2.BackColor = Color.Transparent;
            this.button1.BackColor = Color.Transparent;

            settings1.BringToFront();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            updateScreens();
            tab.Top = button1.Top;
            //this.button1.BackColor = Color.WhiteSmoke;
            this.button2.BackColor = Color.Transparent;
        //    this.button3.BackColor = Color.Transparent;
            homeScreen1.BringToFront();
            
        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }
        Boolean BinShown = false;
        public static int runs;

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (msg.Msg)
            {
                case 0x100:
                case 0x104:
                    switch (keyData)
                    {
                        case Keys.Control | Keys.R:
                            BinShown = !BinShown;
                            foreach (var r in afs)
                            {
                                r.lblDeletedFiles.Visible = BinShown;
                                r.pbDeletedFiles.Visible = BinShown;
                                
                            }
                            break;
                    }
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show(this, "You really want to quit ZThermalManager ?", "Exit",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (res == DialogResult.Yes)
            {
                contextExit = true;
                Application.Exit();
              //  return;
            }
        }

        private void mynotifyicon_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }
        }
        public static bool IsAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
         //   MessageBox.Show(principal.IsInRole(WindowsBuiltInRole.Administrator)?"truee I am admin":"falsee I am not admin");
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        private static void Run1()
        {
            if (!IsAdministrator())
            {
                
                // Restart and run as admin
                var exeName = Process.GetCurrentProcess().MainModule.FileName;
                ProcessStartInfo startInfo = new ProcessStartInfo(exeName);
               startInfo.Verb = "runas";
                startInfo.UseShellExecute = true;
                startInfo.Arguments = (++runs)+"";
                if(runs>1)
                {
                    MessageBox.Show("Can not gain Admin Rights");
                }else 
                Process.Start(startInfo);
                //startInfo.Arguments = "restart";
                main.mynotifyicon.Icon.Dispose();
                main.mynotifyicon.Dispose();
                
                Form1.main.contextExit = true;
                Environment.Exit(1);
                System.Windows.Forms.Application.Exit();
            } 
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            updateScreens();
            tab.Top = button3.Top;
            
            //this.button1.BackColor = Color.Transparent;
            processesList1.BringToFront();

        }

        private void processesList1_Load(object sender, EventArgs e)
        {
           
            
        }

        private void updateScreens()
        {
            addFolder1.updateScreen();
            updateHomeScreen();
            homeScreen1.updateGUI();
            processesList.updateScreen();
            //admin1.updateScreen();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            updateScreens();
            //    this.button2.BackColor = Color.WhiteSmoke;
            tab.Top = button4.Top;
            //   this.button3.BackColor = Color.Transparent;
            //this.button1.BackColor = Color.Transparent;
            admin1.BringToFront();
        }
    }
}
