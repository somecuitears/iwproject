using System;
using System.Collections.Generic;
using System.Text;

namespace IwProject.Oops.Features
{
    public class PolymorphismFeature
    {
        public String Message { get; set; }
        //Method Overloading
        public void MethodOne()
        {
            Console.WriteLine("Function Overloading ");
        }

        public void MethodOne(String message)
        {
            Message = message;
            Console.WriteLine("Function Overloading One Argument. Message: "+ Message);
        }


        //Ad-hoc Overloading or Operator Overloading.

    }
}
