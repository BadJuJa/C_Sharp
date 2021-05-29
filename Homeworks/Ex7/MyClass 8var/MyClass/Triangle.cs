using System;

namespace MyClass {

    internal class Triangle {
        private double a;
        private double b;
        private double c;

        public Triangle(double a, double b, double c) {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void SidesLength() {
            Console.WriteLine($"Стороны треугольника:\n a = {a}\n b = {b}\n c = {c}");
        }

        public double Perimeter() {
            return a + b + c;
        }

        public double Area() {
            double p = (a + b + c) / 2;
            double areaFormule = (p * (p - a) * (p - b) * (p - c));
            return Math.Sqrt(areaFormule);
        }

        public bool Exists() {
            if (a + b <= c || a + c <= b || b + c <= a) {
                return false;
            } else {
                return true;
            }
        }
    }
}