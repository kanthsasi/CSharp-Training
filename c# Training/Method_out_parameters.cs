using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Training
{
    internal class Method_out_parameters
    {
        static void Calculator(int fn, int sn, out int sum, out int product)
        {
           sum = fn + sn;
           product = fn * sn;
           Console.WriteLine("sum:" + sum + "product:" + product);
        }
        static void Main()
        {
            int sum = 0;
            int product = 0;
            Calculator(10, 20, out sum, out product);
            Console.WriteLine("sum:" + sum + "product:" + product);
            Console.ReadLine();   
        }
    }
}
