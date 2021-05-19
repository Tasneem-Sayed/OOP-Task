using System;

namespace MethodReview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(Add());

            Add(1, 2, 3, 54, 1, 8745, 74, 45, 54, 54, 5, 4, 8,10, 8, 5, 8, 85, 8, 8);
            byte[] numbers = { 1, 2, 3, 4, 5 };
            Add(1, 2,numbers);
            Add(y: 10, x: 20);
        }


        static int Add(int x, int y, params int[] numbers)
        {

            int sum = x + y;
            foreach (var item in numbers)
            {
                sum += item;
            }
            return sum;
        }

        static int Add(int x, int y,  byte[] numbers)
        {

            int sum = x + y;
            foreach (var item in numbers)
            {
                sum += item;
            }
            return sum;
        }
        static int Add(int x=10, int y=10)
        {


            return x+y;
        }

        static int Add(short x, short y)
        {


            return x + y;
        }

        static int Add(short x, short y, short z=10)
        {


            return x + y+z;
        }
    }
}
