using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = 10;
            int b = 25;
            int c = 11;
            int d = 22;
            int stephensAge = a + b;
            int mishasAge = c + d;
            double mishasHeight = 177.8;
            double stephensHeight = 187.96;
            bool tallPeople = true;
            char symbol = '@';
            string nameOne = "Stephen";
            string nameTwo = "Misha";
            string heightCm = "cm";

            Console.Write("Hello ");
            Console.Write("World!");
            Console.ReadKey();
            Console.WriteLine(nameOne + " is " + stephensAge + " years old");
            Console.ReadKey();
            Console.WriteLine("He is " + stephensHeight + heightCm + " tall");
            Console.ReadKey();
            Console.WriteLine(nameOne + " is married to " + nameTwo);
            Console.ReadKey();
            Console.Write(nameTwo + " iss\b " + mishasAge + " years Old");
            Console.Write("\t\nwow!\nShe looks much younger though");
            Console.ReadKey();
            Console.ReadKey();
            Console.WriteLine(nameTwo + " is " + mishasHeight + heightCm + " tall");
            Console.ReadKey(true);
            Console.WriteLine("Are they tall people? " + tallPeople);
            Console.ReadKey();
            Console.WriteLine("They live togeter " + symbol + " 34 Some Place");


        }
    }
}
