using IwProject.Oops.Features;
using IwProject.Oops.Features.Abstraction;
using IwProject.Oops.Features.Inheritance;
using System;

namespace IwProject.Oops
{
    class Program
    {
        static void Main(string[] args)
        {
            InheritanceFeature inheritanceFeature = new InheritanceFeature();
            inheritanceFeature.MethodOne();
            inheritanceFeature.MethodTwo();
            Console.WriteLine();
            MultilevelInheritanceFeature multilevelInheritance = new MultilevelInheritanceFeature();
            multilevelInheritance.MethodOne();
            multilevelInheritance.MethodTwo();
            Console.WriteLine();
            ImpInterfaceFeature impInterfaceFeature = new ImpInterfaceFeature();
            impInterfaceFeature.MethodOneI();
            impInterfaceFeature.MethodTwoI();
            impInterfaceFeature.MethodOneIT();
            impInterfaceFeature.MethodTwoIT();
            Console.WriteLine();
            PolymorphismFeature polymorphismFeature = new PolymorphismFeature();
            polymorphismFeature.MethodOne();
            polymorphismFeature.MethodOne("Sent from Main");
            Console.WriteLine();
            EncapsulationFeature encapsulationFeature = new EncapsulationFeature();
            encapsulationFeature.Teat("Encap'd Data");
            Console.WriteLine();
            //Beter Version
            Dog dog = new Dog("Corgi", 4, "Yes", "Tommy", "DogPhylum", 13, "DogSpecies");
            Console.WriteLine("From Dog Object");
            dog.Eat();
            dog.FeedBabys();
            dog.GiveBirth();
            dog.Bark();
            Console.WriteLine(dog.ToString());
            Console.WriteLine();
            Cat cat = new Cat("Wild", 4, "Yes", "Simba", "BigCat", 8, "CatSpecies");
            Console.WriteLine("From Cat Object");
            cat.Eat();
            cat.FeedBabys();
            cat.GiveBirth();
            cat.Meow();
            cat.Purr();
            Console.WriteLine(cat.ToString());
            Console.WriteLine();

            if (cat.Limbs.Equals(dog.Limbs))
            {
                Console.WriteLine("Inheritance....");
            }
            Console.WriteLine();

            Shape2D shape2D = new Shape2D();
            shape2D.Length = 10;
            shape2D.Breadth = 20;
            shape2D.Display();
            Console.WriteLine("Area " + shape2D.Area());
            Console.WriteLine();

            Shape3D shape3D = new Shape3D(10, 20, 30);
            shape3D.Display();
            Console.WriteLine("Volume: " + shape3D.Area());
            Console.WriteLine();
            Console.ReadKey();


        }
    }
}
