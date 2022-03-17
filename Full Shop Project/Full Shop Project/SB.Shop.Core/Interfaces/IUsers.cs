using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Full_Shop_Project.SB.Shop.Core.Interfaces
{
    internal interface IUsers
    {
        public static User CreateClientInstance(string FirstName, string LastName, int PhoneNumber, string Email, string UserName, string Password)
        {
            User newClient = new User();

            newClient.FirstName = FirstName;
            newClient.LastName = LastName;
            newClient.PhoneNumber = PhoneNumber;
            newClient.Email = Email;
            newClient.UserName = UserName;
            newClient.Password = Password;

            return newClient;
        }
    }
}
