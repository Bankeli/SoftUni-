using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Telephony
{
    public class StationaryPhone : ICallable
    {
        public string Call(string phoneNumber)
        {
           bool isValidNumber = phoneNumber.All(c => char.IsDigit(c));
            if (!isValidNumber)
                throw new ArgumentException("Invalid number!");
            return $"Dialing... {phoneNumber}";
        }
    }
}
