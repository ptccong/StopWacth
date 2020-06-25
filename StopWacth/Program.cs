using System;
using System.Diagnostics;
using System.Threading;

namespace StopWacth
{
    class Wacth
    {
        Stopwatch stw = new Stopwatch();
        public void start()
        {
            stw.Start();
        }
        public void stop()
        {
            for(int i = 0; i <= 20; i++)
            {
                Thread.Sleep(10);
            }
            stw.Stop();
        }
        public void show()
        {
            Console.WriteLine("Time :{0}", stw.Elapsed);
        }
       
    }
    class Program
    {
        public static void Main()
        {
            Wacth w = new Wacth();
            w.start();
            w.stop();
            w.show();
        }
    }
}
