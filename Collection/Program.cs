using System;
using System.Collections;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("collection list of array elements");
            ArrayList arrcollection = new ArrayList() { 1,2,3,4,5,1.5,2.5,3.5,4.5,5.5,"komal","neha","nikita","pratima","mahi",'A','B','C','D','E'};


            //arrcollection.Add(1);
            //arrcollection.Add(2);
            //arrcollection.Add(3);
            //arrcollection.Add(4);
            //arrcollection.Add(5);

            //arrcollection.Add(1.5);
            //arrcollection.Add(2.5);
            //arrcollection.Add(3.5);
            //arrcollection.Add(4.5);
            //arrcollection.Add(5.5);

            //arrcollection.Add("KOMAL");
            //arrcollection.Add("MAHI");
            //arrcollection.Add("NIKITA");
            //arrcollection.Add("PRATIMA");
            //arrcollection.Add("NEHA");

            //arrcollection.Add('A');
            //arrcollection.Add('B');
            //arrcollection.Add('C');
            //arrcollection.Add('D');
            //arrcollection.Add('E');

            Console.WriteLine($"Length of Array colleciton is {arrcollection.Count}");
            Console.WriteLine();
            int sum = 0;
            int count = 0;
            foreach(object i in arrcollection)
            {
                if(i is int)
                {
                    sum = sum + (int)i;
                    if((int)i%2==0)
                    {
                        Console.WriteLine("Even numbers are "+(int)i);
                        count++;
                        Console.WriteLine();
                    }
                }
                else if(i is string)
                {
                    string i1 = (string)i;
                    Console.WriteLine($"String name is {(string)i}");
                    Console.WriteLine($"string lenth is {i1.Length}");
                    Console.WriteLine($"Index is {arrcollection.IndexOf((string)i)}");
                    Console.WriteLine();
                }
            }
            Console.WriteLine($"int sum = {sum}");
            Console.WriteLine();
            Console.WriteLine($"Count of even numbers are {count}");
        }
    }
}
