using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSS
{
    public abstract class Customer : ShopItem
    {
        public string _firstName;
        public string _lastName;
        public string _SSN;
        public string _address;
        public string _customerId;
        public bool _isMember;

        public int _noOfShoppingItems;
        public Decimal _currentTotalPrice;
        public Decimal _discount = .05m;
        public Decimal _priceAfterDiscount;

        public Customer customer { get; set; }
        public ShopItem[] customerItems;
        public int MAX_ITEMS_ALLOWED = 6;
        public int MAX_ITEMS_ALLOWED_FOR_MEMBER = 10;
        public Decimal MAX_TOTAL_ALLOWED = 3000;
        public int MAX_TOTAL_ALLOWED_FOR_MEMBER = 6000;

        public Customer()
        {
            _noOfShoppingItems = 0;
            _customerItemCount = 0;
        }

        public Customer(string id, string firstname, string lastname, string address, string ssn, bool membership)
        {
            _firstName = firstname;
            _lastName = lastname;
            _SSN = ssn;
            _address = address;
            _customerId = id;
            _isMember = membership;

        }

        public string FullName 
        {
            get 
            {
                return _firstName + " " + _lastName;
            }
        }

        public abstract void BuysAnItem(ShopItem item);

        public void itemNotSold (ShopItem item)
        {
            item._Availibility = true;
            if (_isMember)
            {
                _currentTotalPrice -= _priceAfterDiscount;
            }
            else
            {
                _currentTotalPrice -= item._Price;
            }
            _noOfShoppingItems--;
        }

        //public void AddsItem(ShopItem item, Customer customer)
        //{
        //    _CustomerItems[customer._customerItemCount] = item;
        //    customer._customerItemCount++;
        //}

        public bool IsMaxFurnitureLimitReached()
        {
            if (_isMember == true)
            {
               return _noOfShoppingItems > MAX_ITEMS_ALLOWED_FOR_MEMBER;
            }
            return _noOfShoppingItems > MAX_ITEMS_ALLOWED;
        }

        public bool IsMaxTotalPriceLimitReached()
        {
            if (_isMember == true)
            {
                return _currentTotalPrice >= MAX_TOTAL_ALLOWED_FOR_MEMBER;
            }
            return _currentTotalPrice >= MAX_TOTAL_ALLOWED;
        }

        //public void PrintCustomerItems()
        //{

        //    for (int i = 0; i < customerItems.Length; i++)
        //    {
        //        ShopItem customer = customerItems[i];
        //        if (customer != null)
        //        {
        //            customer.PrintInfo();
        //        }
        //    }
        //}

        public void PrintInfo()
        {
            System.Console.WriteLine("\n**************** Customer Info ******************");
            System.Console.WriteLine("Customer ID: " + _customerId);
            System.Console.WriteLine("Customer Full Name: " + FullName);
            System.Console.WriteLine("Customer Address: " + _address);
            System.Console.WriteLine("Customer SSN: " + _SSN);
            System.Console.WriteLine("Customer Number of Items Bought " + _customerItemCount);
            System.Console.WriteLine("Customer Total Price of Items Bought: " + _currentTotalPrice);
            //System.Console.WriteLine("List of Items Bought:");
            //PrintCustomerItems();
        }
    }

}
