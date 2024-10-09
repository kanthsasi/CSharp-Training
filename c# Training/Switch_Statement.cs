using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Training
{
    internal class Switch_Statement
    {
        static void Main()
        {
            Console.WriteLine("Enter The Number:");
            int number = int.Parse(Console.ReadLine());
            switch(number)
            {
                case 10:
                    Console.WriteLine("Your number is 10");
                    break;
                case 20:
                    Console.WriteLine("Your number is 20");
                    break;
                case 30:
                    Console.WriteLine("Your number is 30");
                    break;
                case 40:
                    Console.WriteLine("Your number is 40");
                    break;
                default:
                    Console.WriteLine("Please enter the valid number");
                    break;
            }
            //Goto statement.
            Console.WriteLine("Enter The Number:");
            int num = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 10:
                    
                case 20:
                    
                case 30:
                    
                case 40:
                    Console.WriteLine("Your number is {0}",num);
                    break;
                default:
                    Console.WriteLine("Please enter the valid number");
                    break;
            }

            Console.ReadLine();
            
                

        }
    }
}
