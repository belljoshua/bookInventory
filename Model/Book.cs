using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookInventory.Model
{
    public class Book : INotifyPropertyChanged
    {
        private string title;
        private string author;
        private int stock;

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                if (title != value)
                {
                    title = value;
                    RaisePropertyChanged("Title");
                }
            }
        }

        public string Author
        {
            get
            {
                return author;
            }

            set
            {
                if (author != value)
                {
                    author = value;
                    RaisePropertyChanged("Author");
                }
            }
        }

        public int Stock
        {
            get
            {
                return stock;
            }

            set
            {
                if (stock != value)
                {
                    stock = value;
                    RaisePropertyChanged("Stock");
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
