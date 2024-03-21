using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSS
{
    public class ShopItem : Inventory
    {
        public int _customerItemCount;
        public ShopItem() { }
        public ShopItem(int id, string title, string description, Decimal price)
        {
            _Id = id;
            _Title = title;
            _Description = description;
            _Price = price;
        }


        public override void PrintInfo(List<Inventory> inventory)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
