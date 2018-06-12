using System;
using System.Collections.Generic;
using System.Text;

namespace IwProject.Oops.Features.Inheritance
{
    public class Mammal : Animal
    {
        //Properties
        public int Limbs { get; set; }
        public String BodyHair { get; set; }

        //Constructors
        public Mammal()
        {
        }

        public Mammal(int limbs, string bodyHair)
        {
            Limbs = limbs;
            BodyHair = bodyHair;
        }

        public Mammal(string name, string phylum, int age, string species) : base(name, phylum, age, species)
        {
        }

        public Mammal(int limbs, string bodyHair,string name, string phylum, int age, string species) : base(name, phylum, age, species)
        {
            Limbs = limbs;
            BodyHair = bodyHair;
        }
        //Methods
        public void GiveBirth()
        {
            Console.WriteLine("Class Mammal : Gives Birth...");
        }

        public void FeedBabys()
        {
            Console.WriteLine("Class Mammal : Feeds Baby..");
        }
    }
}
