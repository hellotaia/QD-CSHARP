using System;

namespace ConsolePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name : ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your email : ");
            string email = Console.ReadLine();

            Console.WriteLine("Enter your age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your 4-digits password : ");
            string pswrd = new string('*', 4);
            Console.WriteLine(pswrd);
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            int password = Convert.ToInt32(Console.ReadLine());

            int namelength = name.Length;
            Console.Clear();

            Console.Write($"Entered data: " +
                $"\n_______________________" +
                $"\n\tname: {name}" +
                $"\n\temail: {email}" +
                $"\n\tage: {age}" +
                $"\n\tpassword: {password}" +
                $"\n_______________________\n");

            Console.WriteLine("Name length: " + namelength);
        }

    }
}
