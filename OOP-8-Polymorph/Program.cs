namespace OOP_8_Polymorph
{

    public class Car
    {
        //создать родительский класс Car c полем quantity, warranty;
        public int quantity;
        public int warranty;

        //добавить виртуальный метод GetQuantity() классу Car для вывода информации в консоль о количестве готовых к эксплуатации машин;
        public virtual void GetQuantity()
        {
            Console.WriteLine($"Cars quantity to use: {quantity}");
        }

        //добавить метод SetWarranty() для изменения срока гарантии;
        public void SetWarranty(int warranty)
        {
            this.warranty = warranty;

        }
    }
    //создать дочерние классы WV, Toyota, унаследовав класс Car;
    //в дочерних классах переопределить и перегрузить методы родительского класса;
    public class WV:Car
    {
        public WV (int q)
        { quantity = q; }
        public override void GetQuantity() 
        {
            Console.WriteLine($"WV cars quantity to use: {quantity}");
        }
        //в дочерних классах создать метод GetFullInfo() с запретом на переопределение при наследовании
        //с выводом полной информации о выпущенном количестве и сроке гарантийного обслуживания в консоль;
        public void GetFullInfo()
        { Console.WriteLine($"WV cars: quantity : {quantity}, warranity: {warranty}"); }
    }

    public class Toyota : Car
    {
        public Toyota(int q)
        { quantity = q; }
        public override void GetQuantity()
        {
            Console.WriteLine($"Toyota cars quantity to use: {quantity}");
        }
        //в дочерних классах создать метод GetFullInfo() с запретом на переопределение при наследовании
        //с выводом полной информации о выпущенном количестве и сроке гарантийного обслуживания в консоль;
        public void GetFullInfo()
        { Console.WriteLine($"Toyota cars: quantity : {quantity}, warranity: {warranty}"); }
    }

    //создать новый класс Audi, унаследоваться от класса WV. В классе Audi переопределить и перегрузить доступные методы;
    public class Audi : WV
    {
        public Audi (int q) : base(q)
        { quantity = q; }

        public override void GetQuantity()
        {
            Console.WriteLine($"Audi cars quantity to use: {quantity}");
        }
        public new void GetFullInfo()
        { Console.WriteLine($"Audi cars: quantity : {quantity}, warranity: {warranty}"); }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //создаем экземпляры классов и вызываем методы.
            WV wv = new WV(123);
            wv.GetQuantity();
            wv.SetWarranty(2);
            wv.GetFullInfo();

            Toyota toyota = new Toyota(1);
            toyota.GetQuantity();
            toyota.SetWarranty(234);
            toyota.GetFullInfo();

            Audi audi = new Audi(10000);
            audi.GetQuantity();
            audi.SetWarranty(0);
            audi.GetFullInfo();
        }
    }
}