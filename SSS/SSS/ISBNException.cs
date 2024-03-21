using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSS
{
    internal class ISBNException : Exception
    {
        public string itemName;
        public string exceptionMessage;
        public string ISBN;
        public DateTime timeStamp;
        public ISBNException() { }

        public ISBNException(string item, string isbn)
        {
            this.itemName = item;
            this.ISBN = isbn;
            exceptionMessage = "Exception occured for item: " + item;
            exceptionMessage += "ISBN number cannot be null or empty.";
            timeStamp = DateTime.Now;
        }

        public override string ToString()
        {
            return "Exception occurred at time: " + timeStamp + "\n" + exceptionMessage + "\n";
        }
    }
}
