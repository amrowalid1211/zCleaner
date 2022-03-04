using startup;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

using System.Xml.Serialization;

namespace startup
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
   


      

        internal static void LoadSettings()
        {


            try
            {
                var roamingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                var filePath = Path.Combine(roamingDirectory, "thermal.xml");
                XmlSerializer mySerializer = new XmlSerializer(typeof(Memory));
                FileStream myFileStream = new FileStream(filePath, FileMode.Open);
                Program.memory = (Memory)mySerializer.Deserialize(myFileStream);
                myFileStream.Close();
            }
            catch { }
          
            
           

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
