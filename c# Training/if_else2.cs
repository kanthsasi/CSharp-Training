using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Training
{
    internal class if_else2
    {
        static void Main()
        {
            //This is && statement.
            int number = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            if (number == 10 && number2 == 20)
            {
                Console.WriteLine("Your number is 10 and 20");
            }
            else
            {
                Console.WriteLine("Your number is not a 10 and 20");
               
            }
            //This is || statement.
            int num = int.Parse(Console.ReadLine());
            if (num == 10 || num == 20)
            {
                Console.WriteLine("Your num is 10 or 20");
            }
            else
            {
                Console.WriteLine("Your num is not a 10 or 20");
            }
            Console.ReadLine();
        }
    }
}
