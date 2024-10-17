using System;
using System.Text;
namespace CSharp_Training3
{
    internal class Diff_between_String_and_StringBuilders
    {
        static void Main()
        {
            /*string userstring = "C#";
            userstring += "Tutorial";//---->This is String+ Method.
            userstring += "for Beginners";
            Console.WriteLine(userstring);*/

            /*StringBuilder userstring =new StringBuilder("C# ");
            userstring.Append("Tutorial ");//---->This is StringBuilder Method.
            userstring.Append("For Beginners");*/

            string userstring = null;
            for (int i = 0; i < 1000; i++)
            {
                userstring += i.ToString()+ " ";
            }
            Console.WriteLine(userstring.ToString());
            Console.ReadLine();
        }
    }
}
