using System;
using System.Collections.Generic;
using System.Text;

namespace CoreConsole.Model
{

    /* TO DO: 
    a.Requiredprivatefields are todoId(int and readonly), description(String), done(bool)and assignee(Person).
    b.Make a constructor that take in todoId(int) and a description(String).
    c.Unit test Todoclass.d.Commit changes */
    
    public class ToDo
    {
        //public string assigneePerson()
        //{            string person = assignee.Person;         }

        //todoId(intand readonly), 
        private static int idCounter = 0;
        public static int IdCounter { get { return idCounter; } }


        //Requiredprivatefields
        int toDoId;
        string description;
        bool done = true;
        Person assignee; 

        public class Assignee // IS THIS NECESSARY? 
        {
            public string Person { get; set; } // auto properties
        }

        // constructor
        public ToDo (int toDoId, string description)
        {
            toDoId = ++idCounter;

            this.toDoId = idCounter;
            this.description = description;
        }
        public string Description
        {
            get { return description; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))

                {
                    throw new ArgumentException("Description is null, empty or consists only of white space.");
                }
                else
                {
                    description = value;
                }
            }
        }

        public string ToDoInformation()
        {
            return $"ToDo id: {toDoId} | Total number of todos so far: {idCounter}\n\nDescription: {description}\n\n";
        }

    }
}
