using System;
using System.Collections.Generic;
using System.Text;

namespace MyClass {
    class ArithmeticProgression: Progression {
        //a(k) = a(1) + (k-1)d
        private double a1;
        private double d;

        public ArithmeticProgression(double a1, double d) {
            this.a1 = a1;
            this.d = d;
        }
        public ArithmeticProgression() {
            a1 = 1;
            d = 1.5;
        }

        override public double GetElement(int k) {
            return a1 + (k-1)*d;
        }

        public override double SumElement(int k) {
            return ((a1 + GetElement(k) / 2) * k);
        }
    }
}
