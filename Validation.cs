using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace EmailPincodeValidation
{
    class Validation
    {
        public static string pin = "^[0-9]{6}$";
        public bool PincodeVal(string pincod)
        {
            Regex Pn = new Regex(pin);
            bool Validate = Pn.IsMatch(pincod);
            return Validate;
        }
    }
}
