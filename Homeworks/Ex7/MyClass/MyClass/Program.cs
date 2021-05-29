using System;

namespace MyClass {
    static class Program {
        public static void Main(string[] args) {
            Book b1 = new Book("Глен Кук", "Хроники черного отряда", "Азбука", 892, 2020);
            Triangle t1 = new Triangle(3, 3, 3);
            Rectangle r1 = new Rectangle(2, 2);

            b1.Show();

            Console.WriteLine("\nТреугольник");
            t1.SidesLength();
            t1.Exists();
            Console.WriteLine($"Периметр: {t1.Perimeter()}");
            Console.WriteLine($"Площадь: {t1.Area()}");

            Console.WriteLine("\nПрямоугольник");
            r1.sidesLength();
            Console.WriteLine($"Периметр: {r1.Perimeter()}");
            Console.WriteLine($"Площадь: {r1.Area()}");
            Console.WriteLine(r1.isSquare);
        }
    }
}