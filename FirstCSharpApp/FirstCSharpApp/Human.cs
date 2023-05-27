using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    class Human
    {

        //Member variables
        private string firstName;

        //Member property; Exposes firstName safely; Must be capitalized
        public string FirstName {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        //Private member
        private string lastName;
        private string eyeColor;

        //Public member
        public int age;

        //Default constructor
        public Human() 
        {
            Console.WriteLine("Basic constructor. Object created");
        }

        //Parameterized Constructor
        public Human(string newFirstName, string newLastName, string newEyeColor, int newAge)
        {
            this.firstName = newFirstName;
            this.lastName = newLastName;
            this.eyeColor = newEyeColor;
            this.age = newAge;
        }

        // Destructor; Finalizer
        //Called if object deleted / goes out of scope
        ~Human()
        {
            //Cleanup statements
            Console.WriteLine("Deconstructing Human object");
        }

        //Public methods
        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, I'm {0} {1} and {2} years old. My eyes are {3}", firstName, lastName, eyeColor, age);
        }

        public void SetFirstName(string newFirstName) 
        {
            try
            {
                this.firstName = newFirstName;
            }
            catch(FormatException)
            {
                Console.WriteLine("Please enter a string.");
            }

        }
        public string GetFirstName()
        {
            return this.firstName;
        }
    }
}
