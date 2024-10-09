using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Training
{
    internal class For_Foreach_loop
    {
        static void Main()
        {
            int[] number = new int[3];
            number[0] = 101;
            number[1] = 102;
            number[2] = 103;
            int i = 0;
            //While loop
            while (i < number.Length)
            {
                Console.WriteLine(number[i]);
                i++;
            }
            //For Loop
            for (int j = 0; j < number.Length; j++)
            {
                Console.WriteLine(number[j]);
            }
            //ForEach Loop
            foreach (int k in number)
                {
                    Console.WriteLine(k);
                }
             Console.ReadLine();
        }
    }
}
