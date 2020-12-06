using System;
using System.Text.RegularExpressions;

namespace Pincode
{
    public class PincodeCheker
    {
        public static string Pincode = "^[0-9]{6}$";
        public bool Pincod(string Pincod)
        {
            Regex Pn = new Regex(Pincode);
            bool Validate = Pn.IsMatch(Pincod);
            return Validate;
        }
    }
}
