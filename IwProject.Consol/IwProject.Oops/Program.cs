using IwProject.Oops.Features;
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

            MultilevelInheritanceFeature multilevelInheritance = new MultilevelInheritanceFeature();
            multilevelInheritance.MethodOne();
            multilevelInheritance.MethodTwo();

            ImpInterfaceFeature impInterfaceFeature = new ImpInterfaceFeature();
            impInterfaceFeature.MethodOneI();
            impInterfaceFeature.MethodTwoI();
            impInterfaceFeature.MethodOneIT();
            impInterfaceFeature.MethodTwoIT();

            PolymorphismFeature polymorphismFeature = new PolymorphismFeature();
            polymorphismFeature.MethodOne();
            polymorphismFeature.MethodOne("Sent from Main");

            Console.ReadKey();
        }
    }
}
