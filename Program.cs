using System;
using System.Collections.Generic;

namespace MethodsExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Numbers();
            //ByThree();
            //AreEqual();
            //EvenOrOdd();
            //PositiveOrNegative();
            //CanVote();
            //IsInRange();
            MultiplicationTable();
        }

        public static void Numbers()
        {
            for (int i = -1000; i <= 1000; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void ByThree()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        public static void AreEqual()
        {
            Console.WriteLine("Enter a number:");
            var num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number:");
            var num2 = int.Parse(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine($"{num1} is equal to {num2}");
            }
            else
            {
                Console.WriteLine($"{num1} is not equal to {num2}");
            }
        }

        public static void EvenOrOdd()
        {
            Console.WriteLine("Please inter a number:");
            var number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is even");
            }
            else
            {
                Console.WriteLine($"{number} is odd");
            }
        }

        public static void PositiveOrNegative()
        {
            Console.WriteLine("Please inter a number:");
            var number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine($"{number} is a negative number");
            }
            else if (number > 0)
            {
                Console.WriteLine($"{number} is a positive number");
            }
            else if (number == 0)
            {
                Console.WriteLine($"{number} is 0");
            }
            else
            {
                Console.WriteLine($"{number} is invalid");
            }
        }

        public static void CanVote()
        {
            Console.WriteLine("Please enter your age:");
            var age = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine($"Congradulations, you have been old enough to vote for {age - 18} years!");
            }
            else Console.WriteLine($"Sorry, you have {18 - age} years until you can vote");
        }

        public static void IsInRange()
        {
            Console.WriteLine("Please pick a number, can be positive or negative");
            var userNum = int.Parse(Console.ReadLine());
            if (userNum >= -10 && userNum <= 10)
            {
                Console.WriteLine($"{userNum} is within the acceptable range");
            }
            else Console.WriteLine($"{userNum} is not within the acceptable range");
        }
        public static void MultiplicationTable()
        {
            Console.WriteLine("Please enter a number to see the products up to 12");
            var userNum = int.Parse(Console.ReadLine());
            Console.WriteLine();
            var numbers = new List<int>();
            var num = 0;
            while (num < 12)
            {
                num++;
                numbers.Add(num);
            }
            foreach (var item in numbers)
            {
                Console.WriteLine(item * userNum);
            }
        }
    }
}
