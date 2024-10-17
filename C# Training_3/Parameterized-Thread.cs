using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp_Training3
{
    class Number
    {
        public void PrintNumbers(object target)
        {
            int number = 0;
            if (int.TryParse(target.ToString(), out number))
            {
                for (int i = 1; i <= number; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
    internal class Parameterized_Thread
    {
        static void Main()
        {
            Console.WriteLine("Please enter the target");
            object target = int.Parse(Console.ReadLine());

            Number number = new Number();
            ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(number.PrintNumbers);
            Thread thread = new Thread(parameterizedThreadStart);
            thread.Start(target);
            Console.ReadLine();
            
        }
    }
}
