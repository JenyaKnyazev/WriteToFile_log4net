using System;
using System.IO;
using log4net;
using System.Diagnostics;
[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace WriteToFile
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
            (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static string iterations(){
            Console.WriteLine("Enter number of iterations");
            int iter = int.Parse(Console.ReadLine());
            int iter2=iter;
            DateTime start=DateTime.UtcNow;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            while(iter>0){
                iter--;
            }
            stopwatch.Stop();
            return  start.Date.ToString("dd/MM/yyyy")+" - Input:"+iter2+" - Time: "+((double)(stopwatch.Elapsed.TotalMilliseconds)).ToString("0.0")+" ms";
        }
        static void Main(string[] args)
        {
            string temp=iterations();
            log.Info(temp);
        }
    }
}
