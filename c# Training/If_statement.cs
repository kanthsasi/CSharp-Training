using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Training
{
    internal class If_statement
    {
        static void Main()
        {
            Console.WriteLine("Enter the Number:");
            int Number = int.Parse(Console.ReadLine());
            if (Number == 1)
            {
                Console.WriteLine("Your Number is one");
            }
            else if (Number == 2)
            {
                Console.WriteLine("Your Number is two");
            }
            else
            {
                Console.WriteLine("Enter the number between 1to2");
            }
            Console.ReadLine();
        }
    }
}
