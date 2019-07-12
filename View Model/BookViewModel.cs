using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookInventory.Model;

namespace BookInventory.View_Model
{
    public class BookViewModel
    {
        public ObservableCollection<Book> Books
        {
            get;
            set;
        }

        public void LoadBooks()
        {
            ObservableCollection<Book> books = new ObservableCollection<Book>();

            books.Add(new Book { Title = "The Cat in the Hat", Author = "Dr. Seuss", Stock = 5 });
            books.Add(new Book { Title = "The Hobbit", Author = "J. R. R. Tolkien", Stock = 3 });
            books.Add(new Book { Title = "Harry Potter and the Philosopher's Stone", Author = "J. K. Rowling", Stock = 8 });

            Books = books;
        }

        public void AddBook(string title, string author, int stock)
        {
            Books.Add(new Book { Title = title, Author = author, Stock = stock });
        }

        public void RemoveBook(string title, string author)
        {
            foreach (Book book in Books)
            {
                if (book.Title == title && book.Author == author) 
                {
                    Books.Remove(book);
                }
            }
        }
    }
}
