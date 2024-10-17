using System;


namespace C__Training_2
{
    internal class Exception_Handling_Abuse
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter the First Number:");
                int FN = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Second Number:");
                int SN = int.Parse(Console.ReadLine());
                int Result = FN / SN;
                Console.WriteLine(Result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter the number");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Only numbers between:" + Int32.MinValue + Int32.MaxValue);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Denominator cannot be zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
