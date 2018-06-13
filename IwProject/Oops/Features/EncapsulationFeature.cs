using System;

namespace IwProject.Oops.Features
{
    public interface IStudent
    {
        void SomeMethod();
    }

    public class LStudent : IStudent
    {
        public void SomeMethod()
        {
            Console.WriteLine("Implementaion Style One");
        }
    }

    public class FStudent : IStudent
    {
        public void SomeMethod()
        {
            Console.WriteLine("Different Implementaion");
        }
    }

    //Hiding Information. Data not accessed directly.
    public class EncapsulationFeature
    {
        private IStudent sl = new LStudent(); //Private Class Variable.
        public String EncapsuledData { get; set; }  //Encap example.

        //LStudent lStudent = new LStudent();
        public void Teat(String msg)
        {
            EncapsuledData = msg;
            sl.SomeMethod();
            sl = new FStudent();
            //lStudent = new FStudent(); //Now allowed

            Console.WriteLine(EncapsuledData); 
        }

    }
}
