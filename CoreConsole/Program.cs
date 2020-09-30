using CoreConsole.Model;
using System;
using System.Collections.Generic;

namespace CoreConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            Console.WriteLine("Amount of persons: " + Person.Counter);

            persons.Add(new Person("Sinead", "Jacobsson"));
            persons.Add(new Person(null, null));

            Console.WriteLine("Amount of persons: " + Person.Counter);

            foreach (Person aPerson in persons)
            {
                Console.WriteLine(aPerson.PersonInformation());
            }

            List<ToDo> toDos = new List<ToDo>();
            Console.WriteLine("Amount of to dos: " + Person.Counter);




        }
    }
}
