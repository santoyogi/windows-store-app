using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSS
{
    public class RegularCustomer : Customer
    {
        public string _regularCustomerId;


        public RegularCustomer() { }

        public RegularCustomer(string id, string regularId, string firstname, string lastname, string address, string ssn)
        {
            _customerId = id;
            _firstName = firstname;
            _lastName = lastname;
            _address = address;
            _SSN = ssn;
            _regularCustomerId = regularId;
            _isMember = false;
        }

        public override void BuysAnItem(ShopItem item)
        {
            if (item._Availibility == false)
            {
                System.Console.WriteLine("\n******** Item not available. Item not sold. ***********");
            }
            else
            {
                item._Availibility = false;
                if(item is FurnitureItem)
                {
                    if (item.Price > 500)
                    {
                        item.Price = item.Price - 100;
                    }
                }

                _currentTotalPrice += item._Price;
                _customerItemCount++;

                if (IsMaxFurnitureLimitReached())
                {
                    System.Console.WriteLine("\n************ Maximum Furniture Limit is Reached. Item not sold. ************");
                    itemNotSold(item);
                    return;
                }
                if (IsMaxTotalPriceLimitReached())
                {
                    System.Console.WriteLine("\n************ Maximum Total Price Limit is Reached. Item not sold. ************");
                    itemNotSold(item);
                    return;
                }
            }
        }

            public void PrintInfo()
        {
            System.Console.WriteLine("\n**************** Regular Customer Information ******************");
            base.PrintInfo();
            System.Console.WriteLine("Regular CustomerId: " + _customerId);


        }

    }
}
