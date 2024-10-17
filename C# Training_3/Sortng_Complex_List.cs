using System;
using System.Collections;
using System.Collections.Generic;


namespace CSharp_Training3
{
   public class SortByName : IComparer<Clients>
    {
        public int Compare(Clients x,Clients y)
        {
            return x.name.CompareTo(y.name);
        }
    }
    public class Clients : IComparable<Clients>
    {
        public int id { get; set; }
        public string name { get; set; }
        public int salary { get; set; }

        public int CompareTo(Clients other)
        {
            /* if (this.salary > other.salary)
                 return 1;
             else if (this.salary < other.salary)
                 return -1;
             else
                 return 0;*/
            return this.name.CompareTo(other.name);
            

         }

    }

    internal class Sortng_Complex_List
    {
        static void Main()
        {
            Clients c1 = new Clients() { id = 2, name = "Sasi", salary = 9000 };
            Clients c2 = new Clients() { id = 3, name = "Raja", salary = 3000 };
            Clients c3 = new Clients() { id = 1, name = "Kavin", salary = 7000 };

            List<Clients> clients = new List<Clients>();
            clients.Add(c1);
            clients.Add(c2);
            clients.Add(c3);
            SortByName sortByName = new SortByName();
            clients.Sort(sortByName);
            foreach (Clients sorts in clients)
            {
                Console.WriteLine(sorts.name);
            }
            Console.WriteLine("--------------------------------------------------");
            clients.Sort((x, y) => x.salary.CompareTo(y.salary));
            foreach (Clients clients2 in clients)
            {
                Console.WriteLine(clients2.salary);
            }
            Console.WriteLine("--------------------------------------------------");
            clients.Sort();
            foreach(Clients clients1 in clients)
            {
                Console.WriteLine("Name={0},Salary={1}",clients1.name,clients1.salary);
            }
            Console.ReadLine();
        }
    }
}
