namespace OOP_11_Practice
{
    //разработать базовый класс Employee
    public class Employee
    {
        //три закрытых поля – текстовое поле name (фамилия сотрудника), денежные поля salary (зарплата) и bonus (премия).
        private string name;
        private decimal salary;
        private decimal bonus;
        //Oбъявить открытое свойство Name для чтения фамилии сотрудника и открытое свойство Salary для чтения и записи поля зарплаты
        public string Name
        {
            get { return name; } 
        }
        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        //Создать конструктор с параметрами name и salary (задается фамилия и зарплата).
        public Employee(string name, decimal salary) 
        { 
        this.name = name;
        this.salary = salary;
        }
        // Создать виртуальный метод SetBonus(), устанавливающий премию к зарплате, размер которой передается как денежный параметр bonus. 
        public virtual void SetBonus(decimal bonus) 
        { 
            this.bonus = bonus;
        }
        //создать метод ToPay(), возвращающий значение просуммированных зарплаты и премии сотрудника;
        public decimal ToPay()
        {
            return salary + bonus;
        }
    }
    //класс SalesPerson наследовать от класса Employee.
    public class SalesPerson : Employee
    {
        //объявить закрытое целочисленное поле percent (процент выполнения плана продаж).
        private int percent;
        //Создать конструктор с параметрами name, salary и percent, первые два из которых передавать в конструктор базового класса.
        public SalesPerson (string name, decimal salary, int percent): base (name, salary)
        {
            this.percent = percent;
        }
        //Переопределить виртуальный метод родительского класса SetBonus()
        public override void SetBonus(decimal bonus)
        {
            //если продавец выполнил план больше, чем на 100%, то его премия удваивается, а если больше, чем на 200% - премия утраивается;
            if (percent > 100) { bonus = bonus * 2; }
            else if (percent > 200) { bonus = bonus * 3; }
             base.SetBonus(bonus); 
        }
    }
    //класс Manager наследовать от класса Employee.
    public class Manager : Employee
    {
        //объявить закрытое целочисленное поле quantity (количество клиентов, которых обслужил менеджер в течение месяца).
        private int quantity;
        //Создать конструктор с параметрами name, salary и clientAmount (количество обслуженных клиентов) первые два параметра передавать в конструктор базового класса. 
        public Manager (string name, decimal salary, int clientAmount): base (name, salary) 
        { 
        this.quantity = clientAmount;
        }
        //Переопределить виртуальный метод родительского класса SetBonus()
        public override void SetBonus(decimal bonus)
        {
            //если менеджер обслужил больше, чем 100 клиентов, то его премия увеличивается на 500, а если больше, чем 150 клиентов - премия увеличивается на 1000;
            if (quantity > 100) { bonus = bonus + 500; }
            else if (quantity > 150) { bonus = bonus + 1000; }
            base.SetBonus(bonus); 
        }
    }
    //создать класс Company
    class Company
    {
        // объявить закрытое поле employees – массив объектов типа Employee. 
        private Employee[] employees;
        //Создать конструктор, получающий массив объектов типа Employee произвольной длины.
        public Company(Employee[] employees)
        {
            this.employees = employees;
        }
        //Создать метод GiveEverybodyBonus() с параметром companyBonus, который устанавливает размер базовой премии всем сотрудникам.
        public void GiveEverybodyBonus(decimal companyBonus)
        {
            foreach (Employee employee in employees) 
            {
                employee.SetBonus(companyBonus);
            }
        }
        //Создать метод TotalToPay(), который возвращает сумму компенсации всех сотрудников компании с учетом начисленный бонусов.
        public decimal TotalToPay()
        {
            decimal totalToPay = 0;
            foreach(Employee employee in employees)
            {
                totalToPay += employee.ToPay();
            }
            return totalToPay;
        }
        //Создать метод GetNameSalary(), возвращающий фамилию сотрудника и размер его компенсации с учетом бонуса.
        public string GetNameSalary(int i)
        {
            Employee employee = employees[i];
            return $"Name: {employee.Name}, Total to Pay: {employee.ToPay()}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[]
            {
                new SalesPerson("Sales SuperJohn", 800, 380),
                new SalesPerson ("Sales PoorBill", 800, 90),
                new SalesPerson ("Sales RegularJane", 800, 120),
                new Manager ("Manager SuperMaggie", 1000, 180),
                new Manager ("Manager PoorDiana", 1000, 20),
                new Manager ("Manager RegularMike", 1000, 103),
                new Employee ("Employee WhoThatGuy", 12300),
                new Employee ("Employee Janitor", 290),
            };
            Company company = new Company(employees);
            Console.WriteLine($"\tEmployees salary without bonuces:");
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine(company.GetNameSalary(i));
            }
            Console.WriteLine($"Total to pay: {company.TotalToPay()}");
            Console.WriteLine();
            company.GiveEverybodyBonus(300);
            Console.WriteLine("Giving 300 everybody!..processing..");
            Console.WriteLine();
            Console.WriteLine($"\tEmployees salary with bonuces:");
            for (int i = 0; i < employees.Length; i++) 
            {
                Console.WriteLine(company.GetNameSalary(i));
            }
            Console.WriteLine($"Total to pay: {company.TotalToPay()}");

        }
    }
}