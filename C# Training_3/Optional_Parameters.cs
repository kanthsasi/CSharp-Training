using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Training3
{
    internal class Optional_Parameters
    {
        public class Addition
        {
            public void Add(int fnum, int snum, params int[] restofthenumbers)
            {
                int Result = fnum + snum;
                foreach (int restofnumber in restofthenumbers)
                {
                    Result = Result + restofnumber;
                }
                Console.WriteLine(Result);
            }
        }
        static void Main()
        {
            Addition a = new Addition();
            a.Add(10,20,13,33,22,44,55,66);
            Console.ReadLine();
        }
    }
}
