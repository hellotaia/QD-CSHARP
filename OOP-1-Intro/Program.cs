using System;

namespace OOP_1_Intro
{
    public class CoffeeMachine
    {
        //создаем базовый класс CoffeeMachine;
    }

    public class CoffeeMachinePhillips : CoffeeMachine
    {
        //создаем дочерний класс CoffeeMachinePhilips;
    }

    public abstract class CoffeeOptions
    {
        //создаем абстрактный класс CoffeeOptions, а в нем создаем абстрактный метод MakeLatte;
        public abstract void MakeLatte();
    }

    public class Coffee : CoffeeOptions
    {
        //создаем класс Coffee и наследуем абстрактный класс CoffeeOptions, реализуем абстрактный метод MakeLatte;
        public override void MakeLatte()
        {
            Console.WriteLine("Pure tenderness with milk and love");
        }
    }

    public class Barista
    {
        //создаем класс Barista, в нем приватный метод MakingSecretCoffee;
        private void MakingSecretCoffee()
        {
            Console.WriteLine("some magic to your coffee");
        }
        //добавляем в класс Barista публичный виртуальный(virtual) метод MakingEspresso;
        public virtual void MakingEspresso()
        {
            Console.WriteLine("strong as a tough guy");
        }

    }

    public class Trainee : Barista
    {
        //создаем класс Trainee, наследуемся от класса Barista, переопределяем (override) виртуальный метод родительского класса.
        public override void MakingEspresso()
        {
            Console.WriteLine("Not as strong as you wish");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}