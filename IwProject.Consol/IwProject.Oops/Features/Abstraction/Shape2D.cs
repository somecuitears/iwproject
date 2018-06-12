using System;

namespace IwProject.Oops.Features.Abstraction
{
    public class Shape2D : Calculation
    {
        public Shape2D()
        {
        }

        public Shape2D(int lenght, int breadth)
        {
            Length = lenght;
            Breadth = breadth;
        }

        public int Length { get; set; }
        public int Breadth { get; set; }

        public override int Area()
        {
            return Length * Breadth;
        }

        public override void Display()
        {
            Console.WriteLine(Length + " " + Breadth);
        }
    }
}
