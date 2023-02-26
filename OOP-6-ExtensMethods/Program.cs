namespace OOP_6_ExtensMethods
{
    sealed class Worker
    {
        public int Rate;
        public int TotalHour;

        public Worker(int rate, int totalHour)
        {
            Rate = rate;
            TotalHour = totalHour;
        }

        public double CalculateSalary()
        {
            return Rate * TotalHour * 1.5; //1.5 - коэффициент
        }
    }

    //создать статический класс TopWorker;
    public static class TopWorker
    {
        //в классе TopWorker добавить расширяющий метод CalculateSallaryWithBonus() для класса Worker с коэффициентом 2
        internal static double CalculateSallaryWithBonus(this Worker worker )
        {
            return worker.Rate * worker.TotalHour * 2;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //создать экземпляр класса Worker, проверить его рейт и общее залогированное время;
            Worker worker = new Worker(4, 120);
            double result; 
            //вывести в консоль размер компенсации сотрудника: если он попадает под условия бонуса – вызвав метод CalculateSallaryWithBonus(), если нет – CalculateSallary();
            if (worker.Rate*worker.TotalHour >=500)
            {
                result = worker.CalculateSallaryWithBonus();
                Console.WriteLine($"This is Top Worker: and his salary is {result}");
            }
            else
            {
                result = worker.CalculateSalary();
                Console.WriteLine($"this is regular Worker: and his salary is {result}");
            }
        }
    }
}