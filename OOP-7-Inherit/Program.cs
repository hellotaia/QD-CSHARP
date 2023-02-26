namespace OOP_7_Inherit
{
    //создать два класса: ,базовый класс Shape и дочерний класс Rectangle;
    public class Shape
    {
        //в базовом классе определить поля width, height и создать конструктор с параметрами;
        public double width;
        public double height;

        public Shape(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        //в базовом классе создать метод GetArea() с выводом на консоль значения площади;
        public void GetArea()
        {
            double s = width * height;
            Console.WriteLine( $"Shape area is: {s}"); 
        }
    }
    public class Rectangle : Shape 
    {
        //в дочернем классе определить конструктор с параметрами с вызовом родительского конструктора, с помощью ключевого слова base;
        public Rectangle(double width, double heigh):base(width,heigh)
        {
        }
        //в дочернем классе создать метод GetArea() с выводом на консоль значения площади;
        public void GetArea()
        {
            //S = ½ × a × h, где a – основание треугольника, h – высота
            double s = 0.5 * (base.width * base.height);
            Console.WriteLine($"This rectrangle area is: {s}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //создать объект родительского класса и вызвать метод GetArea();
            Shape shape = new Shape(2, 3);
            shape.GetArea();
            //создать объект дочернего класса и вызвать метод GetArea();
            Rectangle rect = new Rectangle(2,3);
            rect.GetArea();
            //создать два объекта с помощью типа object и использовать операторы проверки типов as/is, для приведения типов. После вызвать метод GetArea() у этих обьектов.
            object shape1 = new Shape(4, 5);
            object shape2 = new Rectangle(4,5);

            if (shape1 is Shape) 
            {
                Shape shapeObj = shape1 as Shape;
                shapeObj.GetArea();
            }
            if (shape2 is Rectangle)
            {
                Rectangle rectObj = shape2 as Rectangle;
                rectObj.GetArea();
            }
        }
    }
}