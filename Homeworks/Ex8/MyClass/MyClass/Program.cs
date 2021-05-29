using System;

namespace MyClass {
    static class Program {
        public static void Main(string[] args) {

            Book b1 = new Book("Глен Кук", "Хроники черного отряда", "Азбука", 892, 2020, 11, true);
            Book b2 = new Book("Толстой Л.Н", "Война и мир", "Наука и жизнь", 1234, 2013, 101, false);
            Magazine mag1 = new Magazine("О природе", 5, "Земля и мы", 2014, 1235, false);

            if (false) {
                b1.Show();

                b2.Show();
                b2.TakeItem();
                b2.Show();

                mag1.Show();
            }

            if (true) {
                Console.WriteLine("Тестирование полиморфизма:");
                Item it;
                it = b2;
                it.TakeItem();
                it.Show();
                it.Return();
                it.Show();
                it = mag1;
                it.TakeItem();
                it.Show();
                it.Return();
                it.Show();
            }

            GeometricProgression gp1 = new GeometricProgression();
            GeometricProgression gp2 = new GeometricProgression(3, 1);

            ArithmeticProgression ap1 = new ArithmeticProgression();
            ArithmeticProgression ap2 = new ArithmeticProgression(3, 2);
            if (false) {
                Console.WriteLine($"gp1^ {gp1.GetElement(3)}");
                Console.WriteLine($"gp2^ {gp2.GetElement(3)}");
                Console.WriteLine($"ap1^ {ap1.GetElement(3)}");
                Console.WriteLine($"ap2^ {ap2.GetElement(3)}");

                Console.WriteLine("Сумма элементов:" + gp2.SumElement(10));
            }
        }
    }
}