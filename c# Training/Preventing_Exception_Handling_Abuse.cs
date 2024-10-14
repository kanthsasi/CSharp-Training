using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Training_2
{
    internal class Preventing_Exception_Handling_Abuse
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter the First Number:");
                int numerator;
                bool IsNumeratorConversionIsSuccesfully = Int32.TryParse(Console.ReadLine(), out numerator);
                if (IsNumeratorConversionIsSuccesfully)
                {
                    Console.WriteLine("Enter the Second Number:");
                    int Denominator;
                    bool IsDenominatorConversionIsSuccesfully = Int32.TryParse(Console.ReadLine(), out Denominator);
                    if (IsDenominatorConversionIsSuccesfully && Denominator != 0)
                    {
                        int Result = numerator / Denominator;
                        Console.WriteLine(Result);
                    }
                    else
                    {
                        if (Denominator == 0)
                        {
                            Console.WriteLine("Denominator cannot be zero");
                        }
                        else 
                        {
                            Console.WriteLine("numerator should be valid number"+Int32.MinValue,Int32.MaxValue);
                        }
                    }
                }
            }
           
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}

    

