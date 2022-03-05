using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Management;
using System.IO;
using System.Runtime.InteropServices;

namespace zCleaner.SCREENS
{
    public partial class processesList : UserControl
    {
        public static Process[] processes;
        public static Panel mainPanel;
        public static processesList processList;
        public processesList()
        {
            InitializeComponent();
            mainPanel = panel1;
            processList = this;
            // Get all processes running on the local computer.
            CheckForIllegalCrossThreadCalls = false;
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public static string GetProcessPath(int processId)
        {
            string MethodResult = "";
            try
            {
                string Query = "SELECT ExecutablePath FROM Win32_Process WHERE ProcessId = " + processId;

                using (ManagementObjectSearcher mos = new ManagementObjectSearcher(Query))
                {
                    using (ManagementObjectCollection moc = mos.Get())
                    {
                        IEnumerable<object> q = (from mo in moc.Cast<ManagementObject>() select mo["ExecutablePath"]);
                        if (q.First()!=null)
                        {
                            string ExecutablePath = q.First().ToString();

                            MethodResult = ExecutablePath;

                        }

                    }

                }

            }
            catch (Exception ex)
            {
                //ex.HandleException();
            }
            return MethodResult;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            Process[] processes = Process.GetProcesses();

            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog1.FileName;
                string processName = "";
               
                
                Memory.AddProcess(selectedFileName, new DateTime(2020, 1, 1, 0, 0, 30), new DateTime(2020, 1, 1, 0, 0, 30));
            }
            updateScreen();
        }
        static List<addedProcessItem> afs; 
        public static void updateScreen()
        {
            processesList.processList.scanAfterTimer.Value = Form1.memory.scanAfterTimer;
            processesList.mainPanel.Controls.Clear();
            afs = new List<addedProcessItem>();
            foreach (var x in Form1.memory.processesToHandle)
            {
                addedProcessItem afi = new addedProcessItem();
                afi.FolderName.Text = Path.GetFileName(x.path);
                afi.FolderPath.Text = x.path;
                //ShutdownTimer
                afi.chkbxRelaunch.Checked = x.relaunch;
                afi.shutdownEachTimerDateTime.Tag = x;
                afi.shutdownEachTimerDateTime.Value = x.hours;
                afi.shutdownEachTimerDateTime.ValueChanged += ShutdownEachTimer_ValueChanged1;
                afi.runAfterTimerDateTime.Tag = x;
                afi.runAfterTimerDateTime.Value = x.restartTime;
                afi.runAfterTimerDateTime.ValueChanged += RunAfterTimer_ValueChanged;
                afi.pictureBox1.Image = System.Drawing.Icon.ExtractAssociatedIcon(x.path).ToBitmap();
                afs.Add(afi);
                afi.Dock = DockStyle.Top;
                afi.btnDelete.Tag = x;
                afi.btnDelete.Click += BtnDelete_Click;

                processesList.mainPanel.Controls.Add(afi);
            }
        }

        private static void ShutdownEachTimer_ValueChanged1(object sender, EventArgs e)
        {
            DateTimePicker s = (DateTimePicker)sender;
            if ( s.Value.Hour == 0 && s.Value.Minute == 0 && s.Value.Second < 1)
            {
                s.Value = new DateTime(2020, 1, 1, 0, 0, 1);
            }
            return;
          
        }
        private static void RunAfterTimer_ValueChanged(object sender, EventArgs e)
        {
            return;
            //no more autosave 
            DateTimePicker s = (DateTimePicker)sender;
            if (s.Value.Day==0 && s.Value.Hour == 0 && s.Value.Minute == 0 && s.Value.Second <30)
            {
                s.Value = new DateTime(2020, 1, 0, 0, 0, 30);
            }
            Console.WriteLine(s.Tag);
            ProcessToHandle dts = (ProcessToHandle)s.Tag;
            dts.restartTime = s.Value;
            Memory.saveSettings();
        }
        private static void BtnDelete_Click(object sender, EventArgs e)
        {
            PictureBox btn = (PictureBox)sender;
            ProcessToHandle pth = (ProcessToHandle) btn.Tag;
            //foreach()
          
            Form1.memory.processesToHandle.Remove(pth);
            Memory.saveSettings();
            Scheduler.initializeProcessTimer();
            updateScreen();
        }

      

      
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(var x in afs)
            {
                DateTimePicker s = x.runAfterTimerDateTime;
                if (s.Value.Day == 0 && s.Value.Hour == 0 && s.Value.Minute == 0 && s.Value.Second < 30)
                {
                  //  s.Value = new DateTime(2020, 1, 0, 0, 0, 30);
                }
                Console.WriteLine(s.Tag);
                ProcessToHandle dts = (ProcessToHandle)s.Tag;
                dts.restartTime = s.Value;
                s = x.shutdownEachTimerDateTime;
                dts.relaunch = x.chkbxRelaunch.Checked;
                Console.WriteLine(s.Tag);
                dts = (ProcessToHandle)s.Tag;
                dts.hours = s.Value;
            }
            Form1.memory.scanAfterTimer = new DateTime(scanAfterTimer.Value.Ticks);
            Memory.saveSettings();
            Scheduler.initializeProcessTimer();
            MessageBox.Show("Timers Saved");
        }

        public void updateProcessesStatus(ProcessToHandle pth,string status)
        {
            foreach(var x in afs)
            {
                if(x.FolderPath.Text == pth.path)
                {
                    switch(status)
                    {
                        case "RUNNING":
                            x.lbl_status.Text = status;
                            x.lbl_status.BackColor = Color.ForestGreen;
                            break;
                        case "HANGING":
                            x.lbl_status.Text = status;
                            x.lbl_status.BackColor = Color.IndianRed;
                            break;
                        case "OFF":
                            x.lbl_status.Text = status;
                            x.lbl_status.BackColor = Color.DarkGray;
                            break;
                        default:
                            x.lbl_status.Text = status;
                            x.lbl_status.BackColor = Color.Red;
                            break;
                    }
                }
            }
        }
    }
}
