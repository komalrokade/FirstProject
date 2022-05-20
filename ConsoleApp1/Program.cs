using System;

namespace ConsoleApp1
{
    class Program
    {
        /// <summary>
        /// Enter Point Method
        /// All methods of the programm class will be static
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Output Statement
            //Console is a class under System Namespace
            Console.WriteLine("Hello World!");
            int x, y, z;
            Console.WriteLine("Enter the value of x");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of y");
            y = Convert.ToInt32(Console.ReadLine());
            z = x + y;
            //"z" is a string
            //+ is the operatoe which is overloade for string Concatination
            Console.WriteLine("The value of z is " + z);
            //inpur statement, waits for the input from the console
            Console.ReadLine();
            Console.WriteLine("Program run succeess");
        }       
    }
}
