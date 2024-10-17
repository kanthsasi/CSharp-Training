using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Training_2
{
    internal class Multicast_Delegate
    {
        public delegate void SampleDelegate();
        public static void SampleMethod1()
        {
            Console.WriteLine("SampleMethod1 Invoked");
        }
        public static void SampleMethod2()
        {
            Console.WriteLine("SampleMethod2 Invoked");
        }
        public static void Main()
        {
            
            SampleDelegate s = new SampleDelegate(SampleMethod1);
            s += SampleMethod2;
            s();
            Console.ReadLine();
        }
    }
}
