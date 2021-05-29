using System;

namespace MyClass {

    internal class MyData {
        private DateTime date;

        public DateTime Date {
            get {
                return date;
            }
            set {
                date = value;
            }
        }

        public bool isLeap {
            get {
                return DateTime.IsLeapYear(Date.Year);
            }
        }

        public MyData() {
            this.date = new DateTime(2009, 01, 01);
        }

        public MyData(string s) {
            this.date = DateTime.Parse(s);
        }

        public MyData(int day, int month, int year) {
            this.date = new DateTime(year, month, day);
        }

        public DateTime PreviousDay() {
            return Date.AddDays(-1);
        }

        public DateTime NextDay() {
            return Date.AddDays(1);
        }

        public int DaysToEndOfMonth() {
            return DateTime.DaysInMonth(Date.Year, Date.Month) - Date.Day;
        }
    }
}