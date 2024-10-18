using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp_Training3
{
 
    internal class Protecting_Shared_Resource_in_Multithreading
    {
        static int Total = 0;
        static void Main()
        {
            Thread thread1 = new Thread(AddOneMillion);
            Thread thread2 = new Thread(AddOneMillion);
            Thread thread3 = new Thread(AddOneMillion);
            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread1.Join();
            thread2.Join();
            thread3.Join();
            Console.WriteLine("Total:"+Total);
            Console.ReadLine();
        }
        public static void AddOneMillion()
        {
            for (int i = 0; i <= 100; i++)
            {
                Interlocked.Increment( ref Total);
                //Console.WriteLine(Total);
                Console.WriteLine(Environment.ProcessorCount);
            }
            
        }

    }
}
