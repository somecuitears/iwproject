using System;
using System.Collections.Generic;
using System.Text;

namespace IwProject.Oops.Features.Inheritance
{
    public class Cat : Mammal
    {
        //Properties
        public String Type { get; set; }

        //Constructor
        public Cat()
        {
        }

        public Cat(string type)
        {
            Type = type;
        }

        public Cat(int limbs, string bodyHair) : base(limbs, bodyHair)
        {
        }

        public Cat(string name, string phylum, int age, string species) : base(name, phylum, age, species)
        {
        }

        public Cat(string type,int limbs, string bodyHair,string name, string phylum, int age, string species) : base(name, phylum, age, species)
        {
            Type = type;
        }

        //Methods
        public void Purr()
        {
            Console.WriteLine("Class Cat : Purrr...");
        }

        public void Meow()
        {
            Console.WriteLine("Class Cat : Meow....");
        }
        //Runtime-Polymorphism
        public override void Eat()
        {
            Console.WriteLine("Overridden:: Drinks Milk...");
        }

      

    }
}
