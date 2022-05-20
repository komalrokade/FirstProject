using System;

namespace cs_SimpleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BASIC OPERATIONS ON OOPS");
            operations op = new operations();
            Console.WriteLine();

            double rRaiseTo = op.RaiseTo(10, 2);
            Console.WriteLine($"RaiseTo of given numbers are {rRaiseTo}");
            Console.WriteLine();

            int rfactorial = op.factorial(5);
            Console.WriteLine($"Factorial of given number is {rfactorial}");
            Console.WriteLine();

            double rTrignomentry = op.trignomentry("Cos", 0);
            Console.WriteLine($"Trignometry of given Cos number is {rTrignomentry}");
            Console.WriteLine();

            double aTrignomentry = op.trignomentry("Sin", 30);
            Console.WriteLine($"Trignometry of given Sin number is {aTrignomentry}");
            Console.WriteLine();

            double bTrignomentry = op.trignomentry("Tan", 45);
            Console.WriteLine($"Trignometry of given Tan number is {bTrignomentry}");
            Console.WriteLine();

            double return_value = op.area("circle", new double[] { 10, 5, 5 });
            double return_value1 = op.area("rectangle", new double[] { 10, 5, 5 });
            double return_value2 = op.area("elipse", new double[] { 10, 5, 5 });
            double return_value3 = op.area("triangle", new double[] { 10, 5, 5 });
            double return_value4 = op.area("square", new double[] { 10, 5, 5 });

            Console.WriteLine($"area of circle {return_value}");
            Console.WriteLine($"area of rectangle {return_value1}");
            Console.WriteLine($"area of elipse {return_value2}");
            Console.WriteLine($"area of triangle {return_value3}");
            Console.WriteLine($"area of square {return_value4}");
            Console.WriteLine();
        }
    }

    public class operations
    {
        private bool Validate(int x, int y)
        {
            if (x == 0 || y == 0)
                return false;
            else
                return true;
        }

        public double RaiseTo(int x, int y)
        {
            if (!Validate(x, y)) return 0;
            double z = Math.Pow(x, y);
            return z;
        }

        public int factorial(int x)
        {
            int fact = 1;
            int num;
            Console.WriteLine("Enter the number");
            num = Convert.ToInt32(Console.ReadLine());
            fact = num;
            for(int i=num-1;i>=1;i--)
            {
                fact = fact * i;
            }
            return fact;
        }

        public double trignomentry(string x,double y)
        {
            if(x == "Cos")
            {
                double cos = Math.Cos(y);
                return cos;
            }
            if (x == "sin")
            {
                double sin = Math.Sin(y);
                return sin;
            }
            if (x == "tan")
            {
                double tan = Math.Tan(y);
                return tan;
            }
            else return 0;
        }

        public double area(string shape, double[] dimensions)
        {
            if(shape == "circle")
            {
                return 3.14 * dimensions[0] * dimensions[0];
            }
            else if(shape == "rectangle")
            {
                return dimensions[1] * dimensions[2];
            }
            else if(shape == "elipse")
            {
                return 3.14 * dimensions[1] * dimensions[2];
            }
            else if (shape == "triangle")
            {
                return 0.5 * dimensions[1] * dimensions[2];
            }
            
            else
            {
                return dimensions[1] * dimensions[1];
            }
        }


    }
}
