using System;
using System.Collections.Generic;
using System.Text;

namespace IwProject.Oops.Features
{
    //Inherited AbstractionFeature. Only one base class can be inherited. we cannot inherit multiple class. 
    public class InheritanceFeature : AbstractionFeature
    {
        public override void MethodOne()
        {
            Console.WriteLine("Inherited... Method One");
        }

        public override void MethodTwo()
        {
            Console.WriteLine("Inherited... Method Two");
        }
    }

    //However, multilevel inheritance can be achieved by inheriting class that has already inherited a base class.
    public class MultilevelInheritanceFeature: InheritanceFeature
    {
        public override void MethodOne()
        {
            Console.WriteLine("Multilevel Inheritance... Method One can be changed if needed.");
        }
    }
}
