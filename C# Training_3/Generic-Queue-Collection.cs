using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Training3
{
    public class Custom
    {
        public int id { get; set; }
        public string name { get; set;}
        public string gender { get; set; }
    }
    internal class Generic_Queue_Collection
    {
        static void Main()
        {
            Custom c1 = new Custom() {id=1,name="Sasi",gender="Male" };
            Custom c2 = new Custom() {id=2,name="Sanjiv",gender="Male" };
            Custom c3 = new Custom() {id=3,name="Keerthi",gender="Female" };
            Custom c4 = new Custom() {id=4,name="Sujadha",gender="Female" };
            Custom c5 = new Custom() {id=5,name="Saran",gender="Male" };

            Queue<Custom> queue = new Queue<Custom>();
            queue.Enqueue(c1);
            queue.Enqueue(c2);
            queue.Enqueue(c3);
            queue.Enqueue(c4);
            queue.Enqueue(c5);

            Custom cus1 = queue.Dequeue();
            Console.WriteLine(cus1.id+" - "+cus1.name);
            Console.WriteLine("Totel Item in Queue"+queue.Count);
            Console.WriteLine("--------------------------------------------");
            Custom cus2 = queue.Dequeue();
            Console.WriteLine(cus2.id + " - " + cus2.name);
            Console.WriteLine("Totel Item in Queue" + queue.Count);
            Console.WriteLine("--------------------------------------------");
            Custom cus3 = queue.Peek();
            Console.WriteLine(cus3.id+" - "+cus3.name);
            Console.WriteLine("Totel Item in Queue" + queue.Count);
            Console.WriteLine("--------------------------------------------");
            Custom cus4 = queue.Peek();
            Console.WriteLine(cus4.id + " - " + cus4.name);
            Console.WriteLine("Totel Item in Queue" + queue.Count);
            Console.WriteLine("--------------------------------------------");
            if (queue.Contains(c1))
            {
                Console.WriteLine("Its Exists");
            }
            else
            {
                Console.WriteLine("Does not Exists");
            }
            Console.ReadLine();
        }
    }
}
