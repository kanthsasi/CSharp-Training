using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp_Training3
{
    internal class Signifiance_of_Thread_Join_and_Thread_IsAlive
    {
        public class ThreadFunction
        {
            public static void ThreadingFunction1()
            {
                Console.WriteLine("Thread1 is Running...");
            }
            public static void ThreadingFunction2()
            {
                Console.WriteLine("Thread2 is Running...");
                Thread.Sleep(5000);
                Console.WriteLine("Thread 2 is About to return");
            }

        }

        static void Main()
        {
            Console.WriteLine("Main function is running");
            Thread thread1 = new Thread(ThreadFunction.ThreadingFunction1);
            thread1.Start();
            Thread thread2 = new Thread(ThreadFunction.ThreadingFunction2);
            thread2.Start();

            thread1.Join(1000);
            Console.WriteLine("Thread1 Function has Completed");
            thread2.Join();
            Console.WriteLine("Thread2 Function has Completed");

            if (thread1.IsAlive)
            {
                Console.WriteLine("Thread1 is not completing its work in 1 sec");
            }
            else
            {
                Console.WriteLine("Thread 1 is completed");
            }
            Console.WriteLine("Main function is Ended");
            Console.ReadLine();


        }




    }
}