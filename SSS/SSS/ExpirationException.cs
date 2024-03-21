using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSS
{
    internal class ExpirationException : Exception
    {
        public string itemName;
        public DateTime Packaging;
        public DateTime Expiration;
        public DateTime timeStamp;
        public string ExceptionMessage;
        public ExpirationException() { }

        public ExpirationException(string item, DateTime packaging, DateTime expiration) 
        {
            this.itemName = item;
            this.Packaging = packaging;
            this.Expiration= expiration;
            ExceptionMessage = "Exception occured for item: " + item;
            ExceptionMessage += ". " + "The expiration date " + expiration + " should be greater than the packaging date " + Packaging + ".";
            timeStamp = DateTime.Now;
        }

        public override string ToString()
        {
            return "Exception occurred at time: " + timeStamp + "\n" + ExceptionMessage + "\n";
        }

    }
}
