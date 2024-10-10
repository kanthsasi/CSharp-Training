using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Training
{
    internal class Datatype_Conversion
    {
        static void Main()
        {
            //Example:1
            int i = 123456;
            //Float is the biggest datatype than int.So,No loss of
            //data and Exception.Hence implicit conversion
            float f = i;
            Console.WriteLine(f);
            
            //Example:2
            float floats = 123.456F;
            int integer = (int)floats;//type convesion
            Console.WriteLine(integer);

            //Example:3
            //Convert String to Integer.
            //Parse()Method
            //If we know the value is valid then we use parse().
            String strnumber = "100";
            int a = int.Parse(strnumber);
            Console.WriteLine(a);

            //Example:4
            //TryParse()
            //We did not know Extract value so we use TryParse().
            String str = "100";
            int Result = 0;
            bool isConversionSucessfully =int.TryParse(str,out Result);
            if (isConversionSucessfully)
            {
                Console.WriteLine(Result);
            }
            else {
                Console.WriteLine("Enter the valid input");
            }
            Console.ReadLine();
        }
    }
}
