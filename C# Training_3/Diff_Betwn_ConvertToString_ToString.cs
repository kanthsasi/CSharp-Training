using System;


namespace CSharp_Training3
{
    internal class Diff_Betwn_ConvertToString_ToString
    {
        public class Customer
        {
            public string Name { get; set; }
        }
        static void Main()
        {
            /*Customer c =null;
            Console.WriteLine(c.ToString());//----->This will throw an NotNullReference Exception.
            */
            /*Customer c = null;
            Console.WriteLine(Convert.ToString(c));//---->This will did not throw NotNullReference Exception and cmd promt will null because we give Customer c=null.
            */
            Customer c = new Customer();
            Console.WriteLine(c.ToString());
            Console.ReadLine();
        }
    }
}
