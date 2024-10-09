using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Training
{
    internal class Whileloop_Part_2
    {
        static void Main()
        {
            string UserChoice = string.Empty;
            do
            {

                Console.WriteLine("Enter your Limit:");
                int Userinput = int.Parse(Console.ReadLine());
                int Start = 0;
                while (Start <= Userinput)
                {
                    Console.WriteLine(Start);
                    Start = Start + 2;

                }
                do
                {
                    Console.WriteLine("Do you want to Continue.Please enter yes or no");
                    UserChoice = Console.ReadLine();
                    if (UserChoice != "Yes" && UserChoice != "No")
                    {
                        Console.WriteLine("Invalid Choices,please say yes or no");
                    }
                }
                while (UserChoice != "Yes" && UserChoice != "No");
            }
            while (UserChoice == "Yes");
        
            Console.ReadLine();

        }
    }
}
