using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Training
{
    internal class Whileloop
    {
        static void Main()
        {
           
            Console.WriteLine("Enter your Limit:");
            int Userinput = int.Parse(Console.ReadLine());
            int Start = 0;
            while (Start<= Userinput)
            { 
                Console.WriteLine(Start);
                Start = Start + 2;
                
               
            }
            Console.ReadLine();
        }
    }

}
