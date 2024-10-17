using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace CSharp_Training3
{
    public class Customr
    {
        public int id;
        public string name;
        public int salary;
    }

    internal class Some_Useful_Method_of_List_Collection
    {
        static void Main()
        {
            Customr c1 = new Customr() {id=1,name="Sasi",salary=150000 };
            Customr c2 = new Customr() {id=2,name="Sanjiv",salary=100000 };
            Customr c3 = new Customr() {id=3,name="Manoj",salary=50000 };

            List<Customr> customrs = new List<Customr>();
            customrs.Add(c1);
            customrs.Add(c2);
            customrs.Add(c3);

            bool Result=customrs.TrueForAll(x=>x.salary>=50000);
            Console.WriteLine("Are all salaries greater than 50000:"+Result);
            Console.WriteLine("---------------------------------------------");
            ReadOnlyCollection<Customr> customrs1 = customrs.AsReadOnly();
            Console.WriteLine(customrs1.Count);
            Console.ReadLine();
        }
    }
}
