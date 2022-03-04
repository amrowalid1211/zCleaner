using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace startup
{
    class Program
    {
        public static Memory memory;
        static void Main(string[] args)
        {
            var exeName = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
            ProcessStartInfo startInfo = new ProcessStartInfo(exeName + "\\ZThermalManager.exe");
            Memory.LoadSettings();
            try
            {
                startInfo.UserName = memory.username;
                SecureString theSecureString = new NetworkCredential("", memory.password).SecurePassword; startInfo.Password = theSecureString;
                startInfo.Password = theSecureString;
                startInfo.UseShellExecute = false;
                Process.Start(startInfo);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                startInfo.UserName = null;
                startInfo.Password = null;
                startInfo.UseShellExecute = false;
                Process.Start(startInfo);
            }
        }
    }
}
