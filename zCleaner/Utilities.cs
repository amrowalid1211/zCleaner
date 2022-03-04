using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;
using System.Diagnostics;

namespace zCleaner
{
    public class Utilities
    {
        public static string[] getFiles(string path, Boolean includeSubdirectories = false)
        {
            List<String> filesPath = new List<string>();
            List<String> directoriesPath = new List<string>();
            if(includeSubdirectories)
            ParsePath(path, filesPath, directoriesPath);
            return Directory.GetFiles(path);
        }
        static void ParsePath(string path, List<String> filesPath, List<String> directoriesPath)
        {
            string[] SubDirs = Directory.GetDirectories(path);
            directoriesPath.AddRange(SubDirs);
            filesPath.AddRange(Directory.GetFiles(path));
            foreach (string subdir in SubDirs)
                ParsePath(subdir, filesPath, directoriesPath);

        }

        public static void addToStartUp ()
        {
            try
            {
                
           //     Run1();
                  RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

             //     if (rkApp.GetValue("zThermal") =null && rkApp.GetValue("zThermal").ToString() != Application.ExecutablePath)
                {
                    // Add the value in the registry so that the application runs at startup
                    rkApp.SetValue("zThermal manager", Application.ExecutablePath);
            //        MessageBox.Show("Program Added to startup");
                }
            }
            catch
            {

            }
        }

       
    }
}
