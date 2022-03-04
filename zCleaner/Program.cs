using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace zCleaner
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            String thisprocessname = Process.GetCurrentProcess().ProcessName;
            if (Process.GetProcesses().Count(p => p.ProcessName == thisprocessname) > 1 && args.Length==0)
            {
                
                MessageBox.Show("Another instance is already running");
                Environment.Exit(1);
                System.Windows.Forms.Application.Exit();
                return;
            }
            int runs = 0;
            if(args!=null && args.Length > 0)
            {
                runs += int.Parse(args[0]);
           //     MessageBox.Show("Already tried " + args[0]);
                //return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //  Application.Run(new SplashScreen());
           

           
                
            Application.Run(new Form1(runs));
        }
    }
}
