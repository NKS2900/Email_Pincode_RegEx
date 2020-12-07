using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace EmailPincodeValidation
{
    class Validation
    {
        public static string pin = "^[0-9]{3}[ ][0-9]{3}$";
        public static string EMAIL_PATTERN = "^[a-zA-Z0-9]+[.(a-zA-Z0-9)]*(\\@)[a-zA-Z0-9]+(\\.)[a-z]{2,3}[.(a-z)]*$";
        public bool PincodeVal(string pincod)
        {
            Regex Pn = new Regex(pin);
            bool Validate = Pn.IsMatch(pincod);
            return Validate;
        }
        public bool EmailVal(string email)
        {
            Regex rg = new Regex(EMAIL_PATTERN);        
            bool validate = rg.IsMatch(email);
            return validate;
        }
    }
}
