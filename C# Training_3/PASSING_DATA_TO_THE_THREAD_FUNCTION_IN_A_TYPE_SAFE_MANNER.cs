using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp_Training3
{
    public class Numbers
    {
        public int _target;
        public Numbers(int target)
        {
            this._target = target;
        }
        public void Printnumbers()
        {
            for (int i = 0; i <= _target; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
    internal class PASSING_DATA_TO_THE_THREAD_FUNCTION_IN_A_TYPE_SAFE_MANNER
    {
        static void Main()
        {
            Console.WriteLine("Enter the Limit:");
            int target = int.Parse(Console.ReadLine());
            Numbers numbers = new Numbers(target);
            Thread thread = new Thread(numbers.Printnumbers);
            thread.Start();
            Console.ReadLine();
            
        }
    }
}
