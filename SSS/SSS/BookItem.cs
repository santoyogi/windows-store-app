using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSS
{
    public enum BookType
    {
        Horror,
        SciFi,
        Romance,
        Historical,
        Mystery,
        NonFiction
    }
    public class BookItem : Inventory
    {
        public string _ISBN;
        public string _Author;
        public string _BookType;

        public BookItem() { }

        public BookItem(int id, string title, string description, Decimal price, string isbn, string author, BookType bookType)
        {
            _Id = id;
            _Title = title;
            _Description = description;
            Price = price;
            ISBN = isbn;
            _Author = author;
            genre(bookType);
        }

        public string ISBN
        {
            get { return _ISBN; }
            set
            { 
                _ISBN = value; 
                if(value == string.Empty) 
                {
                    throw new ISBNException(Title, value);
                }
            }
        }

        public void genre(BookType bookType)
        {
            switch (bookType)
            {
                case BookType.Horror:
                    _BookType = "Horror";
                    break;
                case BookType.SciFi:
                    _BookType = "SciFi";
                    break;
                case BookType.Romance:
                    _BookType = "Romance";
                    break;
                case BookType.Historical:
                    _BookType = "Historical";
                    break;
                case BookType.Mystery:
                    _BookType = "Mystery";
                    break;
                case BookType.NonFiction:
                    _BookType = "Non-Fiction";
                    break;
            }

        }

        public override void PrintInfo(List<Inventory> inventory)
        {
            System.Console.WriteLine("*************** Printing Book Information *********************" +
            ToString() + "\nBook Category: " + _BookType + "\nBook Author: " + _Author +
            "\nBook ISBN: " + _ISBN);

        }

    }
}
