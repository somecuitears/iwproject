using System;
using System.Collections.Generic;
using System.Text;

namespace IwProject.Oops.Features.Inheritance
{
    public class Dog : Mammal
    {
        //Properties
        public String Breed { get; set; }

        //Constructors
        public Dog()
        {
        }

        public Dog(string breed)
        {
            Breed = breed;
        }

        public Dog(int limbs, string bodyHair) : base(limbs, bodyHair)
        {
        }

        public Dog(string name, string phylum, int age, string species) : base(name, phylum, age, species) 
        {
        }

        public Dog(string breed,int limbs, string bodyHair, string name, string phylum, int age, string species) : base(limbs, bodyHair, name, phylum, age, species)
        {
            Breed = breed;
        }

        //Methods
        public void Bark()
        {
            Console.WriteLine("Class Dog : Bark.. Bark...");
        }

        public override void Eat()
        {
            base.Eat();
            Console.WriteLine("Overridden:: Eats Meat...");
        }

        //Runtime Polymorphism

    }
}
