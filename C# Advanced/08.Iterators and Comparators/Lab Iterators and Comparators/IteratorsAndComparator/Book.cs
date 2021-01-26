﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace IteratorsAndComparators
{
    public class Book : IComparable<Book>
    {
        public Book(string title, int year, params string[] authors)
        {
            Title = title;
            Year = year;
            Authors = new List<string>(authors);
        }

        public string Title { get; set; }
        public int Year { get; set; }
        public IReadOnlyList<string> Authors { get; set; }

        public int CompareTo( Book book)
        {
            int compare = this.Year.CompareTo(book.Year);
            if (compare == 0)
                compare = this.Title.CompareTo(book.Title);

            return compare;
        }
        public override string ToString() =>  $"{this.Title} - {this.Year}";
        
        
    }
}
