using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Out.WriteLine("Hello you virtual world!");
            Console.Out.WriteLine("This is a bit slow, don't you think?");
            Console.Out.WriteLine("Funkar det med svenska tecken åxå? åäöÅÄÖ$/()|[]\\{}");
            var people = new List<Person>
                             {
                                 new Person() {Name = "Arne Anka", Gender = Gender.Male},
                                 new Person() {Name = "Kajsa Anka", Gender = Gender.Female}
                             };
            foreach (var person in people)
            {
                Console.Out.WriteLine(person.Name + ", " + person.Gender);
            }
            Thread.Sleep(10000);
        }
    }

    internal class Person
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
    }

    enum Gender
    {
        Male, Female
    }
}
