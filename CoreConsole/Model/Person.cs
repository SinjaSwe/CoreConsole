using System;
using System.Collections.Generic;
using System.Text;
using CoreConsole; 

namespace CoreConsole.Model
{
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
                if (string.IsNullOrWhiteSpace(value))

                {
                    throw new ArgumentException("Lastname is null, empty or consists only of white space.");
                }
                else
                {
                    firstname = value;
                }
            }
        }

        public string Lastname
        {
            get { return lastname; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Lastname is null, empty or consists only of white space.");
                }
                else
                {
                    lastname = value;
                }
            }
        }

        public string PersonInformation()
        {
            return $"Person id: {personId} | Total number of people so far: {counter}\n\nFirstname: {firstname}\nLastname: {lastname}\n\n";
        }


    }
}
