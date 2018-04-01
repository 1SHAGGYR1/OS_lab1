using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OS_lab1
{
    class Program
    {
        static volatile bool thread1 = true, thread2 = true;
        static void One()
        {
            while (thread1)
            {
                Console.Write("1");
                Thread.Sleep(100);
            }
        }
        static void Two()
        {
            while (thread2)
            {
                Console.Write("2");
                Thread.Sleep(50);
            }
        }
        static void Main(string[] args)
        {
            Thread firstThread = new Thread(One);
            firstThread.Start();
            Thread secondThread = new Thread(Two);
            secondThread.Start();
            Console.ReadKey();
            thread1 = thread2 = false;
            Console.WriteLine("Threads had stopped.");
            Console.ReadKey();
        }
    }
}
