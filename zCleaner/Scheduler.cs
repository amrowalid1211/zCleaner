﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using zCleaner.SCREENS;
using Timer = System.Windows.Forms.Timer;

namespace zCleaner
{
    public class Scheduler
    {
        public Timer nextScan, processTimer,FreezeDetectionTimer;
        public static List<Timer> stopwatches;
        public void initializeTimer()
        {
          //  scanFolder();
            nextScan = new Timer();
            nextScan.Interval = Form1.memory.scanTime.Hour * 3600000 + Form1.memory.scanTime.Minute * 60000;
            nextScan.Tick += NextScan_Tick;
            nextScan.Start();

            //Freeze Detection Timer
           
            FreezeDetectionTimer = new Timer();
            FreezeDetectionTimer.Interval = Form1.memory.scanAfterTimer.Hour * 3600000 + Form1.memory.scanAfterTimer.Minute * 60000 + Form1.memory.scanAfterTimer.Second * 1000;
            FreezeDetectionTimer.Tick += FreezeDetectionTimer_Tick;
            FreezeDetectionTimer.Start();
        }
        List<ProcessToHandle> shutting = new List<ProcessToHandle>(), turningOn = new List<ProcessToHandle>(); 
        private void FreezeDetectionTimer_Tick(object sender, EventArgs e)
        {
            new Thread(delegate ()
            {
                foreach (var x in Form1.memory.processesToHandle)
                {
                    string processStatus = isRunning(x.path) ? (isResponding(x.path) ? "RUNNING" : "HANGING") : "STOPPED";
                    switch (processStatus)
                    {
                        case "HANGING":
                            if (!shutting.Contains(x))
                            {
                                new Thread(() => killProcessAfter(x, x.hours.Second)).Start();
                                shutting.Add(x);
                                
                            }
                            break;
                        case "STOPPED":
                            if (!turningOn.Contains(x) && x.relaunch)
                            {
                                new Thread(() => ExecuteAsAdminAfter(x, x.restartTime.Second)).Start();
                                turningOn.Add(x);
                                
                            }
                            
                            break;
                        default:
                            shutting.Remove(x);
                            turningOn.Remove(x);
                            break;
                    }


                    processesList.processList.updateProcessesStatus(x, processStatus);

                }
            }).Start();
            
        }

        private void ExecuteAsAdminAfter(ProcessToHandle pt, int time)
        {
            try
            {
                if (isRunning(pt.path))
                    return;
                processesList.processList.updateProcessesStatus(pt, "RELAUNCHING");
                Thread.Sleep(time*1000);
                Process proc = new Process();
                proc.StartInfo.FileName = pt.path;
                proc.StartInfo.WorkingDirectory = Path.GetDirectoryName(pt.path);
                proc.StartInfo.UseShellExecute = true;
                proc.StartInfo.Verb = "runas";

                proc.Start();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void initializeProcessTimer()
        {
            if (stopwatches != null)
                foreach (var x in stopwatches)
                {
                    try
                    {
                        x.Stop();
                    }
                    catch { }
                }
            else stopwatches = new List<Timer>();
            stopwatches.Clear();
            foreach(var x in Form1.memory.processesToHandle)
            {
                
                if((x.restartTime.Minute > 0 || x.restartTime.Second > 0) && !isRunning(x.path))
                    ExecuteAsAdmin(x.path);
                Timer t = new Timer();
                t.Tag = x;
                t.Interval = (int)(x.hours.Hour * 86400000 + x.hours.Minute * 3600000 + x.hours.Second * 60000 );  //Form1.memory.scanTime.Hour * 3600000 + Form1.memory.scanTime.Minute * 60000;
                t.Tick += T_TickAsync;
                t.Start();
                stopwatches.Add(t);
            }
        }

        private static async void T_TickAsync(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer t = (Timer)sender;
            ProcessToHandle pth = (ProcessToHandle)t.Tag;
            string targetProcessPath = pth.path;
            //string targetProcessName = "notepad";

            Process[] runningProcesses = Process.GetProcesses();
            foreach (Process process in runningProcesses)
            {
                try
                {
                    if (
                   process.MainModule != null &&
                   string.Compare(process.MainModule.FileName, targetProcessPath, StringComparison.InvariantCultureIgnoreCase) == 0)
                    {
                        process.Kill();
                        // Thread.Sleep((int)(pth.restartTime * 1000));
                       
                    }
                }
                catch { }
            }
            t.Stop();
            await Delay((pth.restartTime.Minute * 60000 + pth.restartTime.Second * 1000));
            t.Start();
            if (pth.restartTime.Minute>0 || pth.restartTime.Second>0)
            ExecuteAsAdmin(pth.path);
        }
        public static void ExecuteAsAdmin(string fileName)
        {
            try
            {
                Process proc = new Process();
                proc.StartInfo.FileName = fileName;
                proc.StartInfo.WorkingDirectory = Path.GetDirectoryName(fileName);
                proc.StartInfo.UseShellExecute = true;
                proc.StartInfo.Verb = "runas";
             
                proc.Start();
            }catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
           
        }
        public static async Task Delay(long delay)
        {
            while (delay > 0)
            {
                var currentDelay = delay > int.MaxValue ? int.MaxValue : (int)delay;
                await Task.Delay(currentDelay);
                delay -= currentDelay;
            }
        }
        public static bool isRunning(string path)
        {
            Process[] runningProcesses = Process.GetProcesses();
            foreach (Process process in runningProcesses)
            {
                try
                {
                    if (
                   process.MainModule != null &&
                   string.Compare(process.MainModule.FileName, path, StringComparison.InvariantCultureIgnoreCase) == 0)
                    {
                        return true;
                    }
                }
                catch { }

            }
            return false;
        }

        public static bool isResponding (string path)
        {
            Process[] runningProcesses = Process.GetProcesses();
            foreach (Process process in runningProcesses)
            {
                try
                {
                    if (
                   process.MainModule != null &&
                   string.Compare(process.MainModule.FileName, path, StringComparison.InvariantCultureIgnoreCase) == 0)
                    {
                        return process.Responding;
                    }
                }
                catch { }
            }
            return false;
        }

        public static void killProcessAfter(ProcessToHandle pt,int time)
        {

            Thread.Sleep(time*1000);
            processesList.processList.updateProcessesStatus(pt, "TERMINATING");
            Process[] runningProcesses = Process.GetProcesses();
            foreach (Process process in runningProcesses)
            {
                try
                {
                    if (
                   process.MainModule != null &&
                   string.Compare(process.MainModule.FileName, pt.path, StringComparison.InvariantCultureIgnoreCase) == 0)
                    {
                        if(!process.Responding)
                            process.Kill();
                    }
                }
                catch { }
            }
           
        }

        private void ProcessTimer_Tick(object sender, EventArgs e)
        {

        }

        private void NextScan_Tick(object sender, EventArgs e)
        {
            //nextScan.Interval = 200;
            //if (DateTime.Now.Hour == Form1.memory.scanTime.Hour  && DateTime.Now.Minute == Form1.memory.scanTime.Minute && DateTime.Now.Second == 0)
            //{
                //nextScan.Interval = 5000;
                scanFolder();
            //}
            
        }

        public static void scanFolder()
        {
            try
            {
                foreach (var x in Form1.memory.directoryToScans)
                {
                    string[] files = Directory.GetFiles(x.path);
                    List<string> filesToDelete = new List<string>();
                    List<string> filesToZip = new List<string>();
                    foreach (var file in files)
                    {
                        FileInfo fi = new FileInfo(file);
                        long creationDate = File.GetCreationTime(file).Ticks;
                        TimeSpan ts = new TimeSpan(DateTime.Now.Ticks - creationDate);
                        if (ts.TotalMilliseconds > x.RequiredDate.Hour * 86400000 + x.RequiredDate.Minute * 3600000 + x.RequiredDate.Second * 60000)
                        {
                            if (fi.Extension != ".zip")
                            {
                                filesToDelete.Add(file);

                            }

                        }

                    }
                    if (Form1.memory.EnableArchive &&  x.archiveFiles)
                    {
                        x.filesZipped += files.Length;
                        ZipFile.CreateFromDirectory(x.path, x.path + "-Zipped-" + DateTime.Now.ToString("MMddyyHHmmss") + ".zip");
                    }
                    x.filesDeleted = 0;
                    foreach (var file in filesToDelete)
                    {
                    //    if(x.deleteFiles || (x.archiveFiles && Form1.memory.EnableArchive))
                        File.Delete(file);
                     //   if(x.deleteFiles && !x.archiveFiles)
                        x.filesDeleted++;
                    }
                    Memory.saveSettings();
                }
            }catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }finally
            {
                
                Form1.main.updateHomeScreen();
                
            }
            
        }

       
    }
}
