using System;

namespace OOP_2_ObjClassStruct
{
    public class User
    {
        //создать класс User у которого будут поля UserID, Name, Age;
        public int UserId;
        public string Name;
        public int Age;

        //создать конструктор класса для инициализации полей;
        public User(int userid, string name, int age)
        {
            UserId = userid;
            Name = name;
            Age = age;
        }

        //создать метод PrintInfo(), который будет выводить информацию о пользователе;
        public void PrintInfo()
        {
            Console.WriteLine($"User Info: \tuser id: {UserId},\tname: {Name},\tage: {Age}");
        }
        //создать статический метод ChangeUserAge(), который будет присваивать новое значение полю Age;
        public static void ChangeUserAge(User user, int newAge)
        {
            user.Age = newAge;
        }

    }

    class Program
    {

        static void Main(string[] args)
        {
            //создать объект класса User;
            User user = new User(1, "Pete", 12);
            User user2 = new User(2, "Vasia", 13);

            //вызвать метод для вывода информации о пользователе PrintInfo().
            user.PrintInfo();
            user2.PrintInfo();

            //вызвать статический метод ChangeUserAge();
            User.ChangeUserAge(user, 32);
            User.ChangeUserAge(user2, 45);

            //вызвать метод для вывода информации о пользователе PrintInfo().
            user.PrintInfo();
            user2.PrintInfo();
        }
    }
}
