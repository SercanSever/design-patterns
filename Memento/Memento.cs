using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class Memento
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Isbn { get; set; }
        public DateTime LastEdited { get; set; }

        public Memento(string title, string author, int isbn, DateTime lasstEdited)
        {
            Isbn = isbn;
            Title = title;
            Author = author;
            LastEdited = lasstEdited;
        }
    }
}
