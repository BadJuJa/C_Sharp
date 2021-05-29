using System;

namespace MyClass {

    internal class Rectangle {
        private double _a;

        private double _b;

        public double A {
            get {
                return _a;
            }
            set {
                _a = value;
            }
        }

        public double B {
            get {
                return _b;
            }
            set {
                _b = value;
            }
        }

        public bool isSquare {
            get {
                if (_a == _b) {
                    return true;
                } else {
                    return false;
                }
            }
        }

        public Rectangle(double a, double b) {
            this._a = a;
            this._b = b;
        }

        public void sidesLength() {
            Console.WriteLine($"Стороны прямоугольника: а = {_a}, b = {_b}");
        }

        public double Perimeter() {
            return 2 * _a + 2 * _b;
        }

        public double Area() {
            return _a * _b;
        }
    }
}