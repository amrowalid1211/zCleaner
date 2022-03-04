using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace zCleaner
{
    public enum Action
    {
        Zip, Delete
    }
    public class Memory
    {
        public List<DirectoryToScan> directoryToScans;
        public List<ProcessToHandle> processesToHandle;
        public int ScanTimeHours,ScanTimeMinutes;
        public Boolean EnableArchive;
        public Boolean Startup;
        public DateTime scanTime;
        public string username, password;
        public Memory ()
        {
            
            directoryToScans = new List<DirectoryToScan>();
            processesToHandle = new List<ProcessToHandle>();
            ScanTimeHours = 24;
            ScanTimeMinutes = 0;
            scanTime = new DateTime(2020, 10, 10, 1, 0, 0);
            EnableArchive = false;
    //        Memory.saveSettings();
        }
        internal static void AddFolder(string selectedPath,
            bool includeSubDirectories = DefaultValues.includeSubDirectoriesDefault, 
            Action defaultAction = DefaultValues.defaultAction
            )
        {
            foreach(var Xdts in Form1.memory.directoryToScans)
            {
                if(Xdts.path==selectedPath)
                {
                    MessageBox.Show("Folder already exists");
                    return;
                }

            }
            DirectoryToScan dts = new DirectoryToScan();
            dts.path = selectedPath;
            dts.includeSubdirectories = includeSubDirectories;
            dts.action = defaultAction;
            dts.RequiredDate = DefaultValues.OlderThanDays;
            dts.filesDeleted = 0;
            dts.filesZipped = 0;
            dts.deleteFiles = true;
            Form1.memory.directoryToScans.Add(dts);
            saveSettings();
        }
        internal static void UpdateFolder(string selectedPath,
            bool includeSubDirectoriesDefault,
            Action defaultAction ,
            int olderThanDays )
        {
            foreach (var Xdts in Form1.memory.directoryToScans)
            {
                if (Xdts.path == selectedPath)
                {
                    MessageBox.Show("Folder already exists");
                    return;
                }

            }
            DirectoryToScan dts = new DirectoryToScan();
            dts.path = selectedPath;
            Form1.memory.directoryToScans.Add(dts);
            saveSettings();
        }

       

        internal static void AddProcess(string selectedFileName, DateTime killTimeHours, DateTime restartHoursSeconds)
        {
            ProcessToHandle pts = new ProcessToHandle( );
            pts.path = selectedFileName;
            
            pts.hours = killTimeHours; 
            pts.restartTime = restartHoursSeconds;
            pts.isOff = false;
            Form1.memory.processesToHandle.Add(pts);
            Scheduler.initializeProcessTimer();
            saveSettings();
            
        }

        internal static void saveSettings()
        {

            var roamingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var filePath = Path.Combine(roamingDirectory, "thermal.xml");
            XmlSerializer mySerializer = new XmlSerializer(typeof(Memory));
            using (var stream = File.Open(filePath, FileMode.Create))
            {
                mySerializer.Serialize(stream, Form1.memory);

            }
            //StreamWriter myWriter = new StreamWriter(filePath);
            //myWriter.Close();

        }

        internal static void LoadSettings()
        {
            
            
            try
            {
                var roamingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                var filePath = Path.Combine(roamingDirectory, "thermal.xml");
                XmlSerializer mySerializer = new XmlSerializer(typeof(Memory));
                using (var stream = File.Open(filePath, FileMode.Open))
                {
                    Form1.memory = (Memory)mySerializer.Deserialize(stream);

                }
                //FileStream myFileStream = new FileStream(filePath, FileMode.Open);
                //myFileStream.Close();
            }
            catch ( Exception e)
            {
                Form1.memory = new Memory();
                AddFolder(@"C:\Program Files (x86)\Zyter TMS\DF300\hts\alarm");
                AddFolder(@"C:\Program Files (x86)\Zyter TMS\DF300\hts\normal");
                try
                {
                    if(File.Exists(@"C:\Program Files (x86)\Zyter TMS\DF300\hts\HTS2000.exe"))
                        AddProcess(@"C:\Program Files (x86)\Zyter TMS\DF300\hts\HTS2000.exe", new DateTime(2020, 1, 1, 0, 38, 0), new DateTime(2020, 1, 1, 0, 0, 5));
                    if (File.Exists(@"C:\Program Files (x86)\hpws\ODS\AlgorithmServer.exe"))
                        AddProcess(@"C:\Program Files (x86)\hpws\ODS\AlgorithmServer.exe", new DateTime(2020, 1, 1, 0, 38, 01), new DateTime(2020, 1, 1, 0, 1, 10));
                    
                }
                catch { }


            }
            
           

        }

    }
    public class DirectoryToScan
    {
        public string path;
        public Boolean includeSubdirectories;
        public DateTime RequiredDate;
        public Action action;
        public long filesDeleted;
        public long filesZipped;
        public Boolean deleteFiles;
        public Boolean archiveFiles;
    }
    public class DefaultValues
    {
        public const Action defaultAction = Action.Delete;
        public const Boolean includeSubDirectoriesDefault = false;
        public static DateTime OlderThanDays = new DateTime(2020,1,1,1,0,0);
    }
    public class ProcessToHandle
    {
        public string path;
        public DateTime hours,restartTime;
       // public Icon icon;
       
      
        public bool isOff;

        
    }
}
