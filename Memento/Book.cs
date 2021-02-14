using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class Book
    {
        private string title;
        private string author;
        private int ısbn;
        DateTime lastEdited;

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
                SetLastEdited();
            }
        }
        public string Author {
            get
            {
                return author;
            }
            set
            {
                author = value;
                SetLastEdited();
            }
        }
        public int Isbn {
            get
            {
                return ısbn;
            }
            set
            {
                ısbn = value;
                SetLastEdited();
            }
        }

        private void SetLastEdited()
        {
            lastEdited = DateTime.UtcNow;
        }
        public Memento CreateUndo()
        {
            return new Memento(title,author,ısbn,lastEdited);
        }
        public void RestoreFromUndo(Memento memento)
        {
            title = memento.Title;
            author = memento.Author;
            ısbn = memento.Isbn;
            lastEdited = memento.LastEdited;
        } 
        public void ShowBook()
        {
            Console.WriteLine("{0}, {1}, {2} edited : {3}",title,author,ısbn,lastEdited);
        }
    }
}
