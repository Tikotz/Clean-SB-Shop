using Full_Shop_Project.SB.Shop.Core.Interfaces;
using System.Text.RegularExpressions;

namespace Full_Shop_Project.SB.Shop.Services
{
    public class Validations : IValidations
    {
        public bool ValidateEmail(string mail) 
        {
            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            return Regex.Match(mail, pattern).Success;
        }
        public bool ValidateName(string fullName) 
        {
            string IsValidName = @"\D{2,18} \D{2,18}";
            return Regex.Match(fullName, IsValidName).Success;
        }
        public bool ValidatePhone(string phone) 
        {
            string Pattern = @"\+(9[976]\d | 8[987530]\d | 6[987]\d | 5[90]\d | 42\d | 3[875]\d | 2[98654321]\d | 9[8543210] | 8[6421] | 6[6543210] | 5[87654321] | 4[987654310] | 3[9643210] | 2[70] | 7 | 1)\d{ 1,14}$";
            return Regex.Match(phone, Pattern).Success;
        }
        public bool ValidateUserName(string username) 
        {
            string pattern = @"^(?=[a-zA-Z0-9._]{8,20}$)(?!.*[_.]{2})[^_.].*[^_.]$";
            return Regex.Match(pattern, username).Success;
        }
        public bool ValidatePassword(string password) 
        {
            string pattern = @"^(?=[a-zA-Z0-9._]{8,20}$)(?!.*[_.]{2})[^_.].*[^_.]$";
            return Regex.Match(pattern, password).Success;
        }

        
    }
}