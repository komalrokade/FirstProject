using System;

namespace PracticeQuestions
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Qustion no. 2
            //public abstract void Display();
            //o/p = virtual and abstract method cannot be private


            //Questions no. 3
            //protected abstract void display();
            //o/p = it is possible but have to override it

            //Qustion no. 4
            //private static virtual void Show();
            //o/p = virtual and abstract method cannot be private


            //Qustion no. 5
            //Program1.Count = 100;
            //Program1.IncCount();
            //Console.WriteLine($"new count :[0] {Program1.Count}");
            //Console.WriteLine("Press any key");
            //Console.ReadKey();
            //o/p = yes we can have private constructor in public class


            // Qustion no. 6
            //Class obj = new Class();
            //o/p = yes we can have static constructor in public class

            //Qustion no. 7
            //Program obj = new Program1();
            //obj.Test();
            //Program1.Test();
            //Program.Test();
            //Yes abstract class can have static methods


            //Que no 9
            //public int _Month = 1;
            //public int Month
            //{
            //    get => _Month;
            //    set
            //    {
            //        if ((value > 0) && (value < 13))
            //        {
            //            _Month = value;
            //            Console.WriteLine(value);
            //        }
            //    }
            //}
            //no, in abstract class we cannot add properties

            //Qustion no. 10
            //public abstract void Display();
            //o/p = progrm.diplay()is an abstract method but it is contained non-abstract Class program
            //so we cannot add avstract method in non abstract class

            //Qustion no. 11
            //public abstract void Display();
            //Virutal or abstract emmbers cannot be private

            //Qustion no. 12
            //yes


            //Qustion no. 14
            //yes derived class can be sealed but bae class cannot be sealed
            

            //Question no. 15
            //we can have sealed methods 

        }
    }
}

