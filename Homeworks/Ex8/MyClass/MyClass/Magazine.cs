﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyClass {
    class Magazine : Item {
        private string volume;
        private string title;
        private int year;
        private int number;

        public Magazine() {
        }

        public Magazine(string volume, int number, string title, int year, long invNumber, bool taken)
            : base(invNumber, taken) {
            this.volume = volume;
            this.number = number;
            this.title = title;
            this.year = year;
        }

        public override void Show() {
            Console.WriteLine($"\nЖурнал:\n Том:{volume}\n Номер: {number}\n" +
                $" Название: {title}\n Год выпуска: {year}");
            base.Show();
        }

        public override void Return() {
            taken = false;
        }
    }
}
