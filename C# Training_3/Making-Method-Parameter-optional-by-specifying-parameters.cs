using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Training3
{
    internal class Making_Method_Parameter_optional_by_specifying_parameters
    {
        static void Main()
        {
            Add(1, 2, new int[] { 2, 2, 2, 2, 2, 2, 2 });
            Adds(1,c:3);
        }
        public static void Add(int a, int b = 10, int[] c = null)
        {
            int result = a + b;
            foreach (int i in c)
            {
                result += i;
            }

            Console.WriteLine(result);
           // Console.ReadLine();
        }
        public static void Adds(int a, int b = 10, int c = 30)
        {
            Console.WriteLine("A is:" + a);
            Console.WriteLine("B is:" + b);
            Console.WriteLine("C is:" + c);
            Console.ReadLine();
        }
    }
}
