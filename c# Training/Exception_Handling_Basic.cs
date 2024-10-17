using System;
using System.IO;
namespace C__Training_2
{
    internal class Exception_Handling_Basic
    {
        public static void Main()
        {
            StreamReader sr = null;
           
            try
            {

                sr = new StreamReader(@"C:\Sample Files\Data.txt");
                Console.WriteLine(sr.ReadToEnd());
                // sr.Close();

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("please check if the file{0} exists",ex.FileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please select valid location"+ex.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
               
                Console.WriteLine("Finally");
            }
            Console.ReadLine();
        }
    }
}
