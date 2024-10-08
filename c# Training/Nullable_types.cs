using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Training
{
    internal class Nullable_types
    {
        static void Main()
        {
            bool? Areyoumajor = null;
            if (Areyoumajor == true)
            {
                Console.WriteLine("User is Major");
            }
            else if (Areyoumajor == false)
            {
                Console.WriteLine("User is not a Major");
            }
            else
            {
                Console.WriteLine("User is not responding the Question");
            }
            Console.ReadLine();
        }
    }
}
