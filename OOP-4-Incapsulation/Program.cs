using System;

namespace OOP_4_Incapsulation
{
    public class Coffee
    {
        //создать класс Coffee с 2 приватными полями: _name, _price;
        //для полей _name и _price создать свойства set. В свойстве для цены проверить, чтобы значение было > 0;
        private string _name;
        private decimal _price;

        public string Name
        {
            set { _name = value; }
        }
        public decimal Price
        {
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
                else
                {
                    Console.WriteLine("Price should be greater than zero");
                }
            }
        }
        //создать конструктор класса Coffee с параметрами name и price, проинициализировать поля класса;
        public Coffee(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        //создать приватный метод GetInfo(), который будет выводить информацию о напитке;
        private void GetInfo()
        {
            Console.WriteLine($"name: {_name}, price: {_price} hrn");
        }

        //создать публичный метод PrintInfo(), который будет вызывать приватный метод и добавлять в конце строку ;
        public void PrintInfo()
        {
            Console.WriteLine($"Calling private method...");
            GetInfo();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //создать экземпляр класса Coffee. У этого экземпляра класса вызвать метод PrintInfo().
            Coffee coffee = new Coffee("Espresso", -2);
            coffee.PrintInfo();
        }
    }
}
