using System;

namespace MyClass {

    internal class Book: Item {
        private string author;
        private string title;
        private string publisher;
        private int pages;
        private int year;
        private bool returnedOnTime;
        public string Author {
            get {
                return author;
            }
            set {
                author = value;
            }
        }

        public string Title {
            get {
                return title;
            }
            set {
                title = value;
            }
        }

        public string Publisher {
            get {
                return publisher;
            }
            set {
                publisher = value;
            }
        }

        public int Pages {
            get {
                return pages;
            }
            set {
                pages = value;
            }
        }

        public int Year {
            get {
                return year;
            }
            set {
                year = value;
            }
        }

        private static double price = 9;

        public Book() {
        }

        public Book(string author, string title, string publisher, int pages, int year, long invNumber, bool taken) : base(invNumber, taken) {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }

        public Book(string author, string title) {
            this.author = author;
            this.title = title;
        }

        public void SetBook(string author, string title, string publisher,int pages, int year) 
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }

        public static void SetPrice(double price) {
            Book.price = price;
        }

        public override void Show() {
            Console.WriteLine($"\nКнига:\nАвтор: {author}\nНазвание: {title}\n" +
                $"Год издания: {year}\nИздательство: {publisher}\n" +
                $"{pages} стр.\nСтоимость аренды: {price}");
            base.Show();
        }

        public double PriceBook(int s) {
            double cost = s * price;
            return cost;
        }

        static Book() {
            price = 10;
        }

        public void ReturnedOnTime() {
            returnedOnTime = true;
        }

        public override void Return() {
            if (returnedOnTime) {
                taken = false;
            } else {
                taken = true;
            }
        }
    }
}