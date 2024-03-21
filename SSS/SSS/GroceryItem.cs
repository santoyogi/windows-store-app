using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSS
{
    public enum Category
    {
        Produce,
        Fruit,
        Meat,
        Fish,
        Dairy,
        Beverages
    }
    public class GroceryItem : ShopItem
    {
        public DateTime _PackagingDate;
        public DateTime _ExpiryDate;
        public string _categoryType;

        public GroceryItem() { }

        public GroceryItem(int id, string title, string description, Decimal price, Category category, DateTime packagingDate, DateTime expiration)
        {
            _Id = id;
            _Title = title;
            _Description = description;
            _Price = price;
            Packaging = packagingDate;
            Experation = expiration;
            CategoryType(category);
        }

        public void CategoryType(Category category)
        {
            switch (category)
            {
                case Category.Produce:
                    _categoryType = "Produce";
                    break;
                case Category.Fruit:
                    _categoryType = "Fruit";
                    break;
                case Category.Meat:
                    _categoryType = "Meat";
                    break;
                case Category.Fish:
                    _categoryType = "Fish";
                    break;
                case Category.Dairy:
                    _categoryType = "Dairy";
                    break;
                case Category.Beverages:
                    _categoryType = "Beverages";
                    break;
            }

        }

        public DateTime Experation
        {
            get
            {
                return _ExpiryDate;
            }
            set
            {
                _ExpiryDate = value;

                if (_ExpiryDate < _PackagingDate)
                {
                    throw new ExpirationException(_Title, Packaging, Experation);
                }
                _ExpiryDate = value;
            }
        }

        public DateTime Packaging
        {
            get
            {
                return _PackagingDate;
            }
            set
            {

                if (_PackagingDate > _ExpiryDate)
                {
                    throw new ArgumentException("\nPackaging Date cannot be after Experation Date", "Dates");
                }
                _PackagingDate = value;
            }
        }

        public override void PrintInfo(List<Inventory> inventory)
        {
            System.Console.WriteLine("*************** Printing Grocery Information *********************" +
            ToString() + "\nGrocery Category: " + _categoryType + "\nPackaging Date: " + _PackagingDate + "\nExperation Date: " + _ExpiryDate);

        }

    }
}
