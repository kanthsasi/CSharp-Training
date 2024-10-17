using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Training3
{
    internal class Sorting
    {
        static void Main()
        {
            List<int> numbers = new List<int> { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            numbers.Sort();
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("---------------------------------------------------");
            List<string> alphabates = new List<string> {"A","z","b"};
            alphabates.Sort();
            foreach (string alpha in alphabates)
            {
                Console.WriteLine(alpha);
            }
            Console.ReadLine();
    }
    }
}
