using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSS
{
    public class StoreOwner
    {
        public string _firstName;
        public string _lastName;
        public string _address;
        public string _ssn;

        public StoreOwner()
        {

        }

        public StoreOwner(string firstname, string lastname, string address, string ssn)
        {
            _firstName = firstname;
            _lastName = lastname;
            _address = address;
            _ssn = ssn;
        }

        public void AddsAnItem(Inventory item, List<Inventory> inventory)
        {
            if (item is FurnitureItem)
            {
                inventory.Add(item);
            }
            if (item is GroceryItem)
            {
                inventory.Add(item);
            }
            if (item is BookItem)
            {
                inventory.Add(item);
            }

        }



        public void PrintOwnerInfo()
        {
            System.Console.WriteLine("****************** Owner Information*************");
            System.Console.WriteLine("Owner name: " + _firstName + " " + _lastName);
            System.Console.WriteLine("Owner Address: " + _address);
            System.Console.WriteLine("Owner SSN: " + _ssn);
        }

    }
}
