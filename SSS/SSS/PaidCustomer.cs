using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSS
{
    public class PaidCustomer : Customer
    {
        public string _membershipNumber;
        public Decimal _membershipFee = 100;

        public int count;
        
        public PaidCustomer() {
            customerItems = new PaidCustomer[MAX_ITEMS_ALLOWED_FOR_MEMBER];
            count = 0;
        }

        public PaidCustomer(string id, string membershipNum, Decimal membershipFee, string firstname, string lastname, string address, string ssn) 
        { 
            _customerId = id;
            _firstName = firstname;
            _lastName = lastname;
            _address = address;
            _SSN = ssn;
            _membershipNumber = membershipNum;
            _isMember = true;
        }

        public override void BuysAnItem(ShopItem item)
        {
            if (item._Availibility == false)
            {
                System.Console.WriteLine("\n******** Item not available. Item not sold. ***********");
            }
            else { 
                item._Availibility = false;
                _priceAfterDiscount = item.Price * _discount;
                _priceAfterDiscount = item.Price - _priceAfterDiscount;
                if (item is FurnitureItem)
                {
                    if (item.Price > 500)
                    {
                        _priceAfterDiscount = _priceAfterDiscount - 100;
                    }
                }
                _currentTotalPrice += _priceAfterDiscount;
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
            System.Console.WriteLine("\n**************** Membership Customer Information ******************");
            base.PrintInfo();
        }
    }
}
