using System;

namespace Methodexercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your dog's name?");
            string userDogName = Console.ReadLine();

            Console.WriteLine("What is your dog's color of fur?");
            string dogColor = Console.ReadLine();

            Console.WriteLine($"{userName} is {age}.");
            Console.WriteLine($"{userDogName} is his dog. He is a good boy.");
            Console.WriteLine($"His dog's fur is {dogColor}");



        }
    }
}
