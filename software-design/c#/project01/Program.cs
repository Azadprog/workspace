using System;
using System.ComponentModel.DataAnnotations;

namespace project01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Date d1 = new Date();

            d1.Month = 8;

            Console.WriteLine(d1.Month);

            Person p1 = new Person();

            p1.Name = "Shie";
            p1.LastName = "Hit";

            Person p2 = new Person();
            p2.Name = "Hei";


            Console.WriteLine(p1.Name + p1.LastName);
            Console.WriteLine(p1.FullName);
            Console.WriteLine(p2.FullName);

        }
    }



    class Date
    {
        private int _month = -1;

        public int Month
        {
            get { return _month; }
            set {if ((value > 0) && (value < 13)) { _month = value;} }
        }
    }

    class Person
    {
        private string _name ;
        private string _lastName;

        public string Name
        {
            get { return ((_name != null) ? _name : "Unknown"); }
            set
            {
                _name = value;
            }
    }

        public string LastName
        {
            get { return ((_lastName != null) ? _lastName : "Unknown"); }
            set
            {
                _lastName = value;
            }

        }

        public string FullName
        {
            get { return Name + " "+LastName; }
            set
            {
                String[] parts = value.Split(' ');

                Name = parts[0];
                LastName = parts[1];
            }
        }
    }

}
