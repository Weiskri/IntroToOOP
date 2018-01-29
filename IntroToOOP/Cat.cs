using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Cat
    {
        // states
        // fields
        private string name;
        private int age;
        private string furColor;
        private bool isHungry = true;
        private string hairLength;

        // properties
        public string Name
        {
            get { return this.name; } // shows the value of name
            set { this.name = value; } // allows you to change (or assign) the value of name
        }

        public string HairLength
        {
            get { return this.hairLength; }
            set { this.hairLength = value; }
        }

        // behaviors (these are always methods)
        // constructors
        public Cat ()
        {
            // default constructor
            // takes no parameters, so nothing in the parentheses 
        }
        public Cat (string name, int age, string furColor) // (overloaded constructor: has same name, but takes different parameters)
        {
            this.name = name;
            this.age = age;
            this.furColor = furColor;
        }
        public void Eat ()
        {
            if (isHungry) // this conditional is set to true
            {
                isHungry = false; // when the cat eats, it is no longer hungry then
            }
            Console.WriteLine("Is the cat hungry? " + isHungry);
        }

        public void Meow()
        {
            Console.WriteLine("\a");
        }

        public string Hairball()
        {
            if (hairLength == "too long")
            {
                return (this.name + " has a hairball.");
            }
            else
            {
                return (this.name + " is nicely groomed.");
            }
        }
    }
}
