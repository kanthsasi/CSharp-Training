using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Training
{
    internal class Reading_and_Writing_to_a_Console
    {
        static void Main()
        {
            Console.WriteLine("Please enter your firstname:");
            String Firstname = Console.ReadLine();
            Console.WriteLine("Please enter your Lastname:");
            String Lastname = Console.ReadLine();
            //Console.WriteLine("Hello "+Firstname+","+Lastname);
            Console.WriteLine("Hello {0},{1}",Firstname,Lastname);
            Console.ReadLine();
        }
    }
}
