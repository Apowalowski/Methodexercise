using System;

namespace Methodexercise
{
    class Program
    {
        static void Main(string[] args)
        {
        

            Console.WriteLine("Give me a number to add.");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the first one.");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum is {sum}.");


        }
        public static int Sum(int num1, int num2)
        {
            //int sum = num1 + num2;
            //return sum; 

            return num1 + num2;
        }
        public static int Multiply(int x, int y)
        {
            return x * y; 
        }
    }
}
