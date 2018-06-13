using IwProject.Oops.Features;
using IwProject.Oops.Features.Abstraction;
using IwProject.Oops.Features.Inheritance;
using IwProject.Oops.Features.Interface;
using System;

namespace IwProject.Oops
{
    class Program
    {
        static void Main(string[] args)
        {
            OldOne();
            NewOne();
            InterfaceFn();
            Console.ReadKey();
        }

        private static void InterfaceFn()
        {
            Student student = new Student("Ram", "984312345");
            student.Display();
            student.Subjects();
            Console.WriteLine();
            Teacher th = new Teacher()
            {
                Contact = "984521524",
                Name = "Shyam",
            };
            th.Display();
            th.Subjects();

        }

        private static void NewOne()
        {
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
            
        }
        private static void OldOne()
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
        }
    }
}
