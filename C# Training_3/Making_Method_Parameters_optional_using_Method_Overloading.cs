using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Training3
{
    internal class Making_Method_Parameters_optional_using_Method_Overloading
    {
        public class Addition
        {
            public void Add(int fnum, int snum)
            {
                Add(fnum, snum, null);
            }
            public void Add(int fnum, int snum, int[] restofnumbers)
            {
                int Result = fnum + snum;
                foreach (int i in restofnumbers)
                {
                    Result += i;
                }
                Console.WriteLine(Result);
            }
        }
        static void Main()
        {
            Addition a = new Addition();
            a.Add(1, 2, new int[]{ 10,20});
            Console.ReadLine();
        }
    }
}
