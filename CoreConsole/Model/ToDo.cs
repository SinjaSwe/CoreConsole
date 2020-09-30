using System;
using System.Collections.Generic;
using System.Text;

namespace CoreConsole.Model
{

    /* TO DO: 
    a.Requiredprivatefields are todoId(int and readonly), description(String), done(bool)and assignee(Person).
    b.Make a constructor that take in todoId(int) and a description(String).
    c.Unit test Todoclass.d.Commit changes */
    
    class ToDo
    {
        //todoId(intand readonly), 
        private static int idCounter = 0;
        public static int IdCounter { get { return idCounter; } }


        //Requiredprivatefields
        int todoID;
        string description;
        bool done = true;
        //assignee = Person; 

            //ASK ULF AS TO HOW TO BRING IN PERSON FIELD FROM ANOTHER CLASS

    }
}
