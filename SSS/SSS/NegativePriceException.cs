using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSS
{
    internal class NegativePriceException : Exception
    {
        public string itemName;
        public decimal price;
        public DateTime timeStamp;
        public string ExceptionMessage;
        public NegativePriceException()
        {

        }

        public NegativePriceException(string itemName, decimal price)
        {
            this.itemName = itemName;
            this.price = price;
            ExceptionMessage = "Exception occured for item: " + itemName;
            ExceptionMessage += ". " + "The price " + price + " is Negative";
            timeStamp = DateTime.Now;
        }

        public override string ToString()
        {
            return "Exception occurred at time: " + timeStamp + "\n" + ExceptionMessage + "\n";
        }
    }
}
