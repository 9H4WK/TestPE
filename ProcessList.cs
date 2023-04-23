using System.Diagnostics;

namespace TestPE
{
    internal class ProcessList
    {
        public static void ListPs()
        {
            Process[] processes = Process.GetProcesses();
            Console.WriteLine("Processes currently running:\n");

            Console.WriteLine("{0,-40} {1,-20}", "Process Name", "PID");

            foreach (Process process in processes)
            {
                Console.WriteLine("{0,-40} {1,-20}", process.ProcessName, process.Id);
            }
            Console.ReadKey();
        }
    }
}
