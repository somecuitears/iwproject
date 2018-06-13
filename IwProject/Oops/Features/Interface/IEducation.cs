using System;
using System.Collections.Generic;
using System.Text;

namespace IwProject.Oops.Features.Interface
{
    public interface IBasic
    {
        String Name { get; set; }
        String Contact { get; set; }

        void Display();
    }

    public interface ICourse
    {
        void Subjects();
    }

    public interface ITeach
    {
        void Subjects();
    }


    public class Student : IBasic, ICourse
    {
        public Student(string name, string contact)
        {
            Name = name;
            Contact = contact;
        }

        public string Name { get; set; }
        public string Contact { get; set; }

        public void Display()
        {
            Console.WriteLine(Name + " " + Contact);
        }

        public void Subjects()
        {
            Console.WriteLine("Read Subject....");
        }
    }

    public class Teacher : IBasic, ITeach
    {
        public string Name { get; set; }
        public string Contact { get; set; }

        public void Display()
        {
            Console.WriteLine("Mr./Mrs."+Name + " " + Contact);
        }

        public void Subjects()
        {
            Console.WriteLine("Teach Subject....");
        }
    }
}
