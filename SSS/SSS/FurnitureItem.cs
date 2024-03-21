using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSS
{
    public class FurnitureItem : ShopItem
    {

        public Decimal _furnitureHeight;
        public Decimal _furnitureWidth;
        public Decimal _furnitureLength;
        public Decimal _furnitureWeight;

        public FurnitureItem() { }

        public FurnitureItem(int id, string title, string description, Decimal price, Decimal height, Decimal width, Decimal length, Decimal weight)
        {
            _Id = id;
            _Title = title;
            _Description = description;
            Price = price;
            FurnitureHeight = height;
            FurnitureWidth = width;
            FurnitureLength = length;
            FurnitureWeight = weight;
        }

        public Decimal FurnitureHeight
        {
            get { return _furnitureHeight; }
            set { 
                if (value < 0)
                {
                    throw new ArgumentException("\nHeight cannot be negative", "Height");
                }
                _furnitureHeight = value; }
        }

        public Decimal FurnitureWidth 
        {
            get { return _furnitureWidth; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("\nWidth cannot be negative", "Width");
                }
                _furnitureWidth = value;
            }
        }

        public Decimal FurnitureLength
        {
            get { return _furnitureLength; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("\nLength cannot be negative", "Length");
                }
                _furnitureLength = value;
            }
        }

        public Decimal FurnitureWeight
        {
            get { return _furnitureWeight; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("\nWeight cannot be negative", "Weight");
                }
                _furnitureWeight = value;
            }
        }


        public override void PrintInfo(List<Inventory> inventory)
        {
            System.Console.WriteLine("****************** Printing Furiniture Information ****************" + ToString() + "\nHeight: " + _furnitureHeight + "\nWidth: " + _furnitureWidth + 
            "\nLength: " + _furnitureLength + "\nWeight: " + _furnitureWeight);
        }
    }
    

}
