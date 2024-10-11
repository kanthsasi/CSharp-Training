using System;


namespace c__Training
{
    internal class Why_properties_Setter_Getter_method
    {
        public class student
        {
            private int _id;
            private string _names;
            private int _passmark = 35;

            public void Setid(int id)
            {
                if (id <= 0)
                {
                    throw new Exception("Student Id cannot be negative");
                }
                this._id = id;
            }
            public int Getid()
            {
                return this._id;
            }
            public void SetName(string name)
            {
                if (string.IsNullOrEmpty(name))
                {
                    throw new Exception("Name cannot be null and empty");
                }
                this._names = name;
            }
            public string GetName()
            {
                if (string.IsNullOrEmpty(this._names))
                {
                    return "No Name";
                }
                else
                {
                    return this._names;
                }
            }
            public int GetPassmark()
            {
                return this._passmark;
            }
        }
        static void Main() 
        {
            student s = new student();
            s.Setid(101);
            Console.WriteLine("The id is:"+s.Getid());
            s.SetName("SASI KANTH");
            Console.WriteLine("The name is:"+s.GetName());
            Console.WriteLine("The passmark:"+s.GetPassmark());
            Console.ReadLine();
        }
    }
}
