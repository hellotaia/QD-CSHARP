using System;

namespace OOP_3_Constructors
{
    public class Messenger
    {
        //создать класс Messenger;
        //создать статическое поле State;
        public static string State;
        //создать поле message, messageCounter;
        public string message;
        public int messageCounter;
        //создать 2 конструктора: static Messenger (), public Messenger (string message, int messageCounter);

        static Messenger()
        {
            //в статическом конструкторе присвоить значение статическому полю класса State;
            State = "ready";
        }

        public Messenger(string message, int messageCounter)
        {
            //в конструкторе с параметрами присвоить значения полям класса message и messageCounter с помощью this;
            this.message = message;
            this.messageCounter = messageCounter;
        }

        public void Deconstruct(out string _message, out int _msgcount)
        {
            _message = message;
            _msgcount = messageCounter;
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            //создать экземпляры класса Messenger, используя оба конструктора;
            var staticObject = Messenger.State;
            Console.WriteLine($"Messenger State: {Messenger.State}");
            Messenger msgr2 = new Messenger("new message", 2);

            //с помощью деконструктора присвоить переменной значение поля message;
            (string _deconstructMessage, int messageCounter) = msgr2;
            Console.WriteLine(_deconstructMessage);
            Console.WriteLine(messageCounter);
        }
    }
}