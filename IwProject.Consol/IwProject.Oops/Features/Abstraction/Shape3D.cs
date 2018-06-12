using System;
using System.Collections.Generic;
using System.Text;

namespace IwProject.Oops.Features.Abstraction
{
    public class Shape3D:Calculation
    {

        public Shape3D(int lenght, int breadth, int height)
        {
            Lenght = lenght;
            Breadth = breadth;
            Height = height;
        }

        public int Lenght { get; set; }
        public int Breadth { get; set; }
        public int Height { get; set; }

        public override int Area()
        {
            return Lenght * Breadth * Height;
        }

        public override void Display()
        {
            Console.WriteLine(Lenght + " " + Breadth + " " + Height);
        }
    }
}
