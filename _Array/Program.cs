using System;

namespace _Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //RECTANGULAR ARRAY//
            Console.WriteLine("Rectangualar array for numbers");
            string display = string.Empty;
            int[,] intArray =
            {
                {1, 2 },
                {3, 4 },
                {5, 6 }
            };
            for(int row=0; row<intArray.GetLength(0);row++)
            {
                for( int column = 0; column<intArray.GetLength(1);column++)
                {
                    display += intArray[row, column] + "";
                }
                display += '\n';
            }
            Console.WriteLine(display);

            Console.WriteLine("Rectangualar array for characters");

            string disp = string.Empty;
            string[,] strArray =
            {
                {"Apple" },
                {"banana" },
                {"mango" }
            };
            for (int row = 0; row < strArray.GetLength(0); row++)
            {
                for (int column = 0; column < strArray.GetLength(1); column++)
                {
                    disp += strArray[row, column] + " ";
                }
                disp += '\n';
            }
            Console.WriteLine(disp);

            //MULTI-DIMENSIONAL ARRAY//

            int[,] numbers = { { 2, 3 }, { 4, 5 } };
            Console.WriteLine("Elements at index [0,0] :" +numbers[0,0]);
            Console.WriteLine("Elements at index [1,0] :" + numbers[1, 0]);

            numbers[0, 0] = 222;
            Console.WriteLine("New Elements at index [0,0] :" + numbers[0, 0]);

            //USING LOOPS//
            int[,] num = { { 2, 3, 6 }, { 4, 5, 8 } };
            for(int i=0; i<num.GetLength(0);i++)
            {
                Console.WriteLine("Row "+i+": ");
                for(int j=0;j<num.GetLength(1);j++)
                {
                    Console.WriteLine(num[i, j] + ":");
                }
                Console.WriteLine();
            }

            //JAGGED ARRAY//
            int[][] jagged_arr = new int[4][];
            jagged_arr[0] = new int[] { 1, 2, 3, 4 };
            jagged_arr[1] = new int[] { 11, 34, 67 };
            jagged_arr[2] = new int[] { 89,23};
            jagged_arr[3] = new int[] { 10,20,30,40,50 };

            for(int n=0; n<jagged_arr.Length;n++)
            {
                Console.WriteLine($"Row({0}):{n}");

                for(int k=0;k<jagged_arr[n].Length;k++)
                {
                    Console.WriteLine($"[0] {jagged_arr[n][k]}");
                }
                Console.WriteLine();
            }
        }
    }
}
