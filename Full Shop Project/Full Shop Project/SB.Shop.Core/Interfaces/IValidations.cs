using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Full_Shop_Project.SB.Shop.Core.Interfaces
{
    internal interface IValidations
    {
        public static bool ValidateEmail(string mail);
        public static bool ValidateNam(string fullName);
        public static bool ValidatePhone(string phone);
        public static bool ValidateUserName(string username);
        public static bool ValidatePassword(string password);
    }
}
