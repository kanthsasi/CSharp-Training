using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Training
{
    internal class Parameter_Array
    {
        void Parameterarray( params string[] word)
        {
            //Console.WriteLine(number.Length);
            foreach (string k in word)
            {
                Console.WriteLine(k);
            }
        }
        static void Main()
        {
            Parameter_Array pr = new Parameter_Array();
            pr.Parameterarray("Sasi","Guru","Sanjiv");
            Console.ReadLine();
        }
    }
}
