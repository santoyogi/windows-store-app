using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SSS
{
    public abstract class Inventory : Object
    {
        public int _Id;
        public string _Title;
        public string _Description;
        public Decimal _Price;
        public bool _Availibility = true;

        public int MAX_INVENTORY_CAPACITY = 100;

        public Inventory()
        { 
        }

        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }
        public int ID
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public Decimal Price
        {
            get
            {
                return _Price;
            }
            set
            {
                if (value < 0)
                {
                    throw new NegativePriceException(Title, value);
                }
                if (value >= 1000000)
                {
                    throw new ArgumentException("\nPrice cannot exceed 1 Million dollars ", "Price");
                }
                _Price = value;
            }
        }

        public void PrintInventoryInfo(List<Inventory> inventory)
        {
           System.Console.WriteLine("\n************************** Inventory Items List ************************");
           
           PrintInfo(inventory);
                
           
        }

        public object Clone()
        {
            Random random = new Random();
            object obj = MemberwiseClone();
            _Id += random.Next(0, 2000);
            return obj;

        }

        public override string ToString()
        {
            return "\nItem Id: " + _Id + "\nItem title: " + _Title + "\nItem despcription: " + _Description + "\nItem price: " + _Price;
        }

        public abstract void PrintInfo(List<Inventory> inventory);

    }
}
