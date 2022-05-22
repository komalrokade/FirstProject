using System;

namespace Date
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Que 8.
            //Yes we can add private properties in a class
            //private int _Month = 7;
            //public int Month
            //{
            //    get => _Month;
            //    set
            //    {
            //        if((value>0)&&(value<13))
            //        {
            //            _Month = value;
            //            Console.WriteLine(value);
            //        }
            //    }
            //}

            //Que 13
            //public static int a = 10;
            //public void diplay()
            //{ 
            //    Console.WriteLine(a);
            //}
            //Yes we can access static members of a class in non static method
            //public void diplay()
            //{
            //    Console.WriteLine("value of a is" + a);
            //}
        }
    }
 }

