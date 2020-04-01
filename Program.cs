using System;

namespace GitExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            myClass myclass = new myClass("Simon","Hvidovrevej 312");
            myClass myclass2 = new myClass("Bo","Albertslund hovedgade 31");
            myClass myclass3 = new myClass("Per","Taastrup allé 201");
            
            Console.WriteLine($"{myclass}");
            Console.WriteLine($"{myclass2}");
            Console.WriteLine($"{myclass3}");


        }
    }
}
