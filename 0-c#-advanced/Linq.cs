using System;
using System.Collections.Generic;

interface IBook{
    string Title { get; set; }
    string Author { get; set; }

    int Price { get; set; }
}

namespace CSharpJourney{

    class Book: IBook
    {

        public required  string Title { get; set; }
        public required string Author { get; set; }
        public required int Price { get; set; }

        public List<Book> GetAllBooks(){

            List<Book> books = new List<Book> {
                new Book { Title = "C# Advanced", Author = "Mosh Hamedani", Price= 50 },
                new Book { Title = "C# Fundamentals", Author = "Adedoyin", Price= 20 },
                new Book { Title = "C# Beginner", Author = "Adedoyin", Price = 25 },
                new Book { Title = "C# Intermediate", Author = "Adedoyin", Price = 100 },
                new Book { Title = "C# Expert", Author = "Adedoyin", Price = 70 },
             };


            return books;
        }
    }
}