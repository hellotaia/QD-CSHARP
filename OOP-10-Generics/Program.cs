namespace OOP_10_Generics
{
    //создать класс User с полями userID, balance, добавить им свойства;
    public class User
    {
        private int userId;
        private double balance;
        public int UserId 
        {
            get { return userId; } 
            set{ userId = value; }
        }
        public double Balance 
        {
            get { return balance; } 
            set { balance = value; } 
        }
        public User(int userId, double balance) 
        {
            this.userId = userId;
            this.balance = balance;
        }

    }
    //создать обобщенный класс Provider с ограничением типа User;
    public class Provider<U> where U: User
    {
        //в классе Provider добавить обобщенный метод CheckBalance(U user) и вывести в консоль информацию о userID и balance;
        public void CheckBalance(U user)
        {
            Console.WriteLine($"Checking balance...\nUser id: {user.UserId}, balance: {user.Balance}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           //создать экземпляр класcа User, проинициализировать поля
           User user = new User(001, 120.4);
           //создать экземпляр класса Provider вызвать обобщенный метод CheckBalacne(U user), где в качестве параметра передаем ссылку на объект класса User.*/
           Provider<User> provider = new Provider<User>();
           provider.CheckBalance(user);
        }
    }
}