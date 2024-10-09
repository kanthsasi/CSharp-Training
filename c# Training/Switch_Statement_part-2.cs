using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Training
{
    internal class Switch_Statement_part_2
    {
        static void Main()
        {
            
            int TotalCoffeeCost = 0;
            Again:
            Console.WriteLine("1-Small,2-Medium,3-Large");
            Console.Write("Order Your Coffee Type: ");
            int UserChoice = int.Parse(Console.ReadLine());
            switch (UserChoice)
            {
                case 1:
                    TotalCoffeeCost+= 10;
                    break;
                case 2:
                    TotalCoffeeCost+= 20;
                    break;
                case 3:
                    TotalCoffeeCost+= 30;
                    break;
                default:
                    Console.WriteLine("Your order {0} is invalid=",UserChoice);
                    goto Again;
            }
           

        Decision:
            Console.WriteLine("You want to order another coffee Yes Or No");
            Console.WriteLine("Enter Yes or No");
            String UserDecision = Console.ReadLine();
            switch (UserDecision.ToUpper())
            {
                case "YES":
                    goto Again;
                case "NO":
                    break;
                default:
                    Console.WriteLine("Your choice is invalid:"+UserDecision);
                    goto Decision;
            }
            Console.WriteLine("Thank you for visiting");
            Console.WriteLine("Your Bill Amount is:" + TotalCoffeeCost);
            Console.ReadLine();
        }
    }
}
