using System;
using System.IO;

namespace C__Training_2
{
    internal class Inner_Exception
    {
        static void Main()
        {
            try 
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
                catch (Exception ex)
                {
                    string stringpath = @"C:\Sample Files\Data1.txt";
                    if (File.Exists(stringpath))
                    {
                        StreamWriter sw = new StreamWriter(stringpath);
                        sw.Write(ex.GetType().Name);
                        sw.Close();
                        Console.WriteLine("Please enter valid input");
                    }
                    else
                    {
                        throw new Exception(stringpath + "is not present" + ex);
                    }
                }
                
            }
            catch (Exception exception)
            {
                Console.WriteLine("Current Exception:{0}", exception.GetType().Name);

                if (exception.InnerException != null)
                {
                    Console.WriteLine("Inner Exception:{0}" + exception.InnerException.GetType().Name);
                }
            }
            Console.ReadLine();
        }
    }
}
