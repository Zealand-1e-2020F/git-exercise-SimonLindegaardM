using System;

namespace GitExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            myClass myclass = new myClass("Simon","Hvidovrevej 312","Hvidovre");
            myClass myclass2 = new myClass("Bo","Albertslund hovedgade 31","Albertslund");
            myClass myclass3 = new myClass("Per","Taastrup allé 201","Taastrup");
            
            Console.WriteLine($"{myclass}");
            Console.WriteLine($"{myclass2}");
            Console.WriteLine($"{myclass3}");


        }
    }
}
