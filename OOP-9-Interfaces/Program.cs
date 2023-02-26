namespace OOP_9_Interfaces
{
    //создать абстрактный класс Animal с абстрактными методами Sound();
    public abstract class Animal
    {
        public abstract void Sound();   
    }
    //создать 3??? (chetyre) интерфейса IAnimal, IRunable, IEatable, ISleepable.
    //Определить методы в интерфейсах IRunable, IEatable, ISleepable: Run(), Eat(), Sleep() соответственно.
    //Применить множественное наследование интерфейсов (IAnimal имплементирует остальные интерфейсы);

    //в одном из интерфейсов добавить дефолтную реализацию метода;
    //в остальных применить явную реализацию методов;
    public interface IRunable
    {
        void Run();
    }

    public interface IEatable
    {
        void Eat()
        {
            Console.WriteLine("Every animal can eat");
        }
    }

    public interface ISleepable
    {
        void Sleep();
    }
    public interface IAnimal:IRunable, IEatable, ISleepable
    {

    }


    //создать дочерние классы Dog, Cat и наследовать абстрактный класс. Реализовать методы абстрактного класса в дочерних классах;
    //в классах Dog, Cat, которые наследовались от абстрактного класса имплементировать интерфейсы;
    public class Dog: Animal, IAnimal 
    {
        public override void Sound()
        {
            Console.WriteLine("Dog: Woof woof");
        }
        public void Run() { Console.WriteLine("Run dog run"); }

        public void Eat() { Console.WriteLine("Dog eats bones"); }
        public void Sleep() { Console.WriteLine("Dog sleeps in the rug"); }
    }
    public class Cat : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Cat: Meeeow");
        }
        public void Run() { Console.WriteLine("Run cat run"); }

        public void Eat() { Console.WriteLine("Cat eats fish"); }
        public void Sleep() { Console.WriteLine("Cat sleeps in the pillow"); }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //создать экземпляр классов Dog и Cat, вызвать методы, которые реализовали унаследовав абстрактный класс и методы интерфейсов.
            Dog dog = new Dog();
            dog.Sound();
            dog.Run();
            dog.Eat();
            dog.Sleep();
            Console.WriteLine();

            Cat cat = new Cat();
            cat.Sound();
            cat.Run();
            cat.Eat();
            cat.Sleep();
        }
    }
}