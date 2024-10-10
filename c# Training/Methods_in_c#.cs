using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Training
{
    internal class Methods_in_c_
    {
        public void evennumbers()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            
        }

        static void Add(int a,int b)
        {
            int Result = a + b;
            Console.WriteLine(Result);

        }
        static void Main()
        {
            Methods_in_c_.Add(10,20);
            Methods_in_c_ m = new Methods_in_c_();
            m.evennumbers();
            Console.ReadLine();
           
        }
    }
}
