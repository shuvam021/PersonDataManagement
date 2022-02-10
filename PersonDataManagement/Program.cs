using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonDataManagement
{
    class Person
    {
        static int Count { get; set; } = 1;
        public int SSN { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        public Person()
        {
            this.SSN = Count;
            Person.Count += 1;
        }

        public override string ToString()
        {
            return $"Person: SSN: {SSN},\tName: {Name},\tAge: {Age},\tAddress: {Address}";
        }
    }

    class Program
    {
        /// <summary>Create list of Person object</summary>
        /// <returns>Person()[]</returns>
        static List<Person> Creat()
        {
            List<Person> list = new List<Person>();
            var p1 = new Person() { Name = "John", Address = "Knowhere", Age = 21 };
            var p2 = new Person() { Name = "Jane", Address = "Knowhere", Age = 22 };
            var p3 = new Person() { Name = "Jack", Address = "Knowhere", Age = 23 };
            var p4 = new Person() { Name = "Jill", Address = "Knowhere", Age = 24 };
            var p5 = new Person() { Name = "Jason", Address = "Knowhere", Age = 17 };
            var p6 = new Person() { Name = "Jackson", Address = "Knowhere", Age = 60 };
            list.Add(p1);
            list.Add(p2);
            list.Add(p3);
            list.Add(p4);
            list.Add(p5);
            list.Add(p6);
            return list;
        }

        /// <summary>Top 2 Public</summary>
        /// <returns>Public()[]</returns>
        static List<Person> RetrieveTopTwo(List<Person> list)
        {
            return list.FindAll(p => p.Age < 60).Take(2).ToList();
        }

        /// <summary>Print all items of Person()[]</summary>
        static void Retrieve(List<Person> list)
        {
            foreach (var item in list)
                Console.WriteLine(item);
        }
        static List<Person> SearchName(List<Person> list, string name)
        {
            return list.FindAll(p => p.Name.ToLower() == name.ToLower());
        }

        static void Main(string[] args)
        {
            var list = Creat();

            var topTwo = RetrieveTopTwo(list);
            Console.WriteLine("\nuc-2");
            Retrieve(list);

            Console.WriteLine("\nuc-2");
            if (topTwo.Count == 0) Console.WriteLine("List is empty");
            else Retrieve(topTwo);

            Console.WriteLine("\nuc-3");
            var age13To18 = list.FindAll(p => p.Age > 13 && p.Age < 18);
            Retrieve(age13To18);

            Console.WriteLine("\nuc-4");
            Console.WriteLine(list.Average(p => p.Age));

            Console.WriteLine("\nuc-5");
            Retrieve(SearchName(list, "Jack"));

            Console.WriteLine("\nuc-6");
            Retrieve(list.Where(p => p.Age < 60).ToList());
        }
    }
}
