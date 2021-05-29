using System;
using System.Collections.Generic;
using System.Text;

namespace MyClass {
    class GeometricProgression : Progression {
        private double a1;
        private double q;

        public GeometricProgression(double a1, double q) {
            this.a1 = a1;
            this.q = q;
        }
        public GeometricProgression() {
            a1 = 2;
            q = 1.5;
        }

        public override double GetElement(int k) {
            return a1 * Math.Pow(q, k - 1);
        }

        public override double SumElement(int k) {
            if (q != 1) {
                return a1 * ((1 - Math.Pow(q, k)) / 1 - q);
            } else {
                return a1 * k;
            }
        }
    }
}
