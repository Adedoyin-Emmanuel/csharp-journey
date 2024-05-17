using System;
using System.Collections.Generic;


namespace CSharpJourney{

    class Book
    {

        public  string ?Title { get; set; }
        public string ?Author { get; set; }
        public int Price { get; set; }

        public IEnumerable<Book> GetAllBooks(){

            List<Book> books = new List<Book> {
                new Book { Title = "C# Advanced", Author = "Mosh Hamedani", Price= 50 },
                new Book { Title = "C# Fundamentals", Author = "Adedoyin Emmanuel", Price= 20 },
                new Book { Title = "C# Beginner", Author = "Mosh Hamedani", Price = 25 },
                new Book { Title = "C# Intermediate", Author = "Adedoyin Emmanuel", Price = 100 },
                new Book { Title = "C# Expert", Author = "Traversy Media", Price = 70 },
             };

            return books;
        }
    }
}