using System;

namespace MathPractice
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine($"This calculator can prerform such actions:" +
                  $"\n1 - addition" +
                  $"\n2 - substraction" +
                  $"\n3 - multiplication" +
                  $"\n4 - division" +
                  $"\n5 - exit from the calculator");

            Console.WriteLine("Enter your option: ");
            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("1 option - addition");
                    Console.WriteLine("Enter first number");
                    int int1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter second number");
                    int int2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"The sum of numbers is: {int1 + int2} ");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine("2 option - substraction");
                    Console.WriteLine("Enter first number");
                    int1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter second number");
                    int2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"Substrabction result is: {int1 - int2} ");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("3 option - multiplication");
                    Console.WriteLine("Enter first number");
                    int1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter second number");
                    int2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"Multiplication result is: {int1 * int2} ");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("4 option - division");
                    Console.WriteLine("Enter first number");
                    int1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter second number");
                    int2 = Convert.ToInt32(Console.ReadLine());

                    if (int2 == 0)
                    {
                        Console.WriteLine("there's no way to divide a number by zero.");

                    }
                    else
                    {
                        Console.WriteLine($"Division result is: {int1 / int2} ");
                    }
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;

                case "5":
                    Console.Clear();
                    Console.WriteLine("5 option - Exit");
                    Console.WriteLine("Sorry you leave");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Wrong option! You should enter value from 1 to 5 ");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;
            }
            Console.Clear();
            Main();
        }
    }
}