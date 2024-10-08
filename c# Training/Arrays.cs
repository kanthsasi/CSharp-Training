using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Training
{
    internal class Arrays
    {
        static void Main()
        {
            //intialize in single line.
            int[] arr = { 1,2,3,4};
            Console.WriteLine(arr[2]);
            //Intialize in different line.
            int[] evennumber = new int[3];
            evennumber[0] = 0;
            evennumber[1] = 2;
            evennumber[2] = 4;
            Console.WriteLine(evennumber[2]);
            Console.ReadLine();
        }
    }
}
