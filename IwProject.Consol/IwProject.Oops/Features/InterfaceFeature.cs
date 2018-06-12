using System;
using System.Collections.Generic;
using System.Text;

namespace IwProject.Oops.Features
{
    //This class will only contain defination and no implementation.
    public interface InterfaceFeature
    {
        void MethodOneI();
        void MethodTwoI();
    }

    public interface InterfaceFeatureTwo
    {
        void MethodOneIT();
        void MethodTwoIT();
    }


    //Unlike Inheritance, Multiple interface can be implemented by single class.
    public class ImpInterfaceFeature : InterfaceFeature, InterfaceFeatureTwo
    {
        public void MethodOneI()
        {
            Console.WriteLine("Interference... "+ System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        public void MethodOneIT()
        {
            Console.WriteLine("Interference... " + System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        public void MethodTwoI()
        {
            Console.WriteLine("Interference... " + System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        public void MethodTwoIT()
        {
            Console.WriteLine("Interference... " + System.Reflection.MethodBase.GetCurrentMethod().Name);
        }
    }
}
