using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp_Training3
{

    internal class Multithreading
    {
        static void Main()
        {
            Thread thread = new Thread(Primenumbers);
            thread.Start();
            for (int i = 0; i < 5; i = i + 2)
            {
                Console.WriteLine("Main thread Working......");
                Thread.Sleep(1000);
            }

             void Primenumbers()
            {
                for (int i = 0; i < 5; i = i + 2)
                {
                    Console.WriteLine("Background thread is Working......");
                    Thread.Sleep(1000);
                }
                
            }
            Console.ReadLine();
        }
    }
}
