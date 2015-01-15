using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static int i = 0;        

        static void Main(string[] args)
        {
            System.Threading.Timer tmr = new System.Threading.Timer(new System.Threading.TimerCallback(Excute), null, 0, 1000);
            Console.ReadKey();
            tmr.Change(-1, 1000);
            tmr.Dispose();
            Console.ReadKey(); 
        }

        static void Excute(object o)
        {                   
            //System.Threading.Thread.Sleep(3000);
            Console.WriteLine((++i).ToString());                
        }
    }
}
