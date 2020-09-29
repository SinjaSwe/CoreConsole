using System;
using System.Collections.Generic;
using System.Text;

namespace CoreConsole.Model
{
    /* TO DO:

             c.UsePropertiesto prevent namesfromsavingNULL & Empty
             d.Unittest Personclass.
             e.Commitchanges. 
    */
    public class Person
    {

        //personId(intand readonly), 
        private static int counter = 0;
        public static int Counter { get { return counter; } }

        //RequiredPrivateFields

        int personId;
        string firstname;
        string lastname;

        //constructor
        public Person(string firstname, string lastname)
        {
            personId = ++counter;

            this.firstname = firstname;
            this.lastname = lastname;
        }

        public string Firstname
        {
            get { return firstname; }
            set
            {
                if (value == null)
                {
                    firstname = "enter firstname here";
                }
            }
        }

        public string Lastname
        {
            get { return lastname; }
            set
            {
                if (value == null)
                {
                    lastname = "enter lastname here";
                }
            }
        }

        public string PersonInformation()
        {
            return $"Person id: {personId} | Total number of people so far: {counter}\n\nFirstname: {firstname}\nLastname: {lastname}\n\n";
        }


    }
}
