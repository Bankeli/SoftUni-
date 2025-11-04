using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Telephony
{
    public class Smartphone : ICallable, IBrowseable
    {
        public string Call(string phoneNumber)
        {
            bool isValidPhone = phoneNumber.All(c => char.IsDigit(c));
            if (!isValidPhone)
                throw new ArgumentException("Invalid number!");

            return $"Calling... {phoneNumber}";
        }
        public string Browse(string url)
        {
            bool isValidUrl = url.All(c => !char.IsDigit(c));
            if (!isValidUrl)
                throw new ArgumentException("Invalid URL!");
            return $"Browsing: {url}!";
        }

       
    }
}
