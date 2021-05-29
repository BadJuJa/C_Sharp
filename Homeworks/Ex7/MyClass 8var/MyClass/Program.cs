using System;

namespace MyClass {

    internal static class Program {

        public static void Main(string[] args) {
            Book b1 = new Book("Глен Кук", "Хроники черного отряда", "Азбука", 892, 2020);
            Triangle t1 = new Triangle(3, 3, 3);
            MyData md1 = new MyData();
            MyData md2 = new MyData(03, 03, 1998);
            MyData md3 = new MyData("02/02/2011");

            b1.Show();

            Console.WriteLine("\nТреугольник");
            t1.SidesLength();
            t1.Exists();
            Console.WriteLine($"Периметр: {t1.Perimeter()}");
            Console.WriteLine($"Площадь: {t1.Area()}");

            Console.WriteLine("\nДата");
            Console.WriteLine(md1.Date);
            Console.WriteLine(md2.Date);
            Console.WriteLine(md3.Date);

            Console.WriteLine($"Предыдущий день от md1: {md1.PreviousDay()}, следующий: {md1.NextDay()}");
            Console.WriteLine($"Дней до конца месяца: {md1.DaysToEndOfMonth()}");
            Console.WriteLine($"Год високосный: {md1.isLeap}");
        }
    }
}