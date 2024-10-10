using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Training
{
    internal class Method_Parameters
    {
        //pass by value
        //pass by reference 
        //In this program we see pass by reference method.
        static void MethodParameter(ref int j)
        {
            j = 101;
           
        }
        static void Main()
        { 
            int i = 30;
            MethodParameter(ref i);
            Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}
