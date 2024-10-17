using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Training3
{
    public class Custo
    {
        public int id { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
    }
    internal class Generic_Stack_Collection
    {
        static void Main()
        {
            Custo c1 = new Custo() { id = 1, name = "Sasi", gender = "Male" };
            Custo c2 = new Custo() { id = 2, name = "Sanjiv", gender = "Male" };
            Custo c3 = new Custo() { id = 3, name = "Keerthi", gender = "Female" };
            Custo c4 = new Custo() { id = 4, name = "Sujadha", gender = "Female" };
            Custo c5 = new Custo() { id = 5, name = "Saran", gender = "Male" };

            Stack<Custo> stack = new Stack<Custo>();
            stack.Push(c1);
            stack.Push(c2);
            stack.Push(c3);
            stack.Push(c4);
            stack.Push(c5);

            Custo c=stack.Pop();
            Console.WriteLine(c.id+" - "+c.name);
            Console.WriteLine("Total Item in Stack:"+stack.Count);

            Custo c6 = stack.Peek();
            Console.WriteLine(c6.id+" - "+c6.name);
            Console.WriteLine("Total Item In Stack:"+stack.Count);
            Console.ReadLine();
        }
    }
}
