using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Full_Shop_Project.SB.Shop.Core.Interfaces
{
    internal interface IValidations
    {
        public bool ValidateEmail(string mail);
        public bool ValidateName(string fullName);
        public bool ValidatePhone(string phone);
        public bool ValidateUserName(string username);
        public bool ValidatePassword(string password);
    }
}
