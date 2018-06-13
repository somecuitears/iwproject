using System;
using System.Collections.Generic;
using System.Text;

namespace IwProject.Oops.Features.Inheritance
{
    public class Animal
    {
        //Properties
        public String Name { get; set; }
        public String Phylum { get; set; }
        public int Age { get; set; }
        public String Species { get; set; }

        //Constructors
        public Animal()
        {
        }

        public Animal(string name, string phylum, int age, string species)
        {
            Name = name;
            Phylum = phylum;
            Age = age;
            Species = species;
        }

        //Methods
        //For Overriding virtual keyword is use.. doing so we can change the defination by overriding on derived class.
        public virtual void Eat()
        {
            Console.WriteLine("Class Animal : Eating...");
        }

        public void Breath()
        {
            Console.WriteLine("Class Animal : Breathing...");
        }

        public override string ToString()
        {
            return "Overridden ToString Animal: " + Name + " " + Phylum + " " + Age + " " + Species;
        }
    }
}
