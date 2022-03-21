using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Full_Shop_Project.SB.Shop.Core.Interfaces
{
    internal interface IUsers
    {
        public int GetUserId();
        public string GetFullName();
        public string GetUserEmail(int id);
        public int GetUserBudget(int id);
        public int GetPassword(string userName);
        public string GetUserInfo();
        public int GetBudget();
        public int setBudget(int newBudget);
        public int DecBudget(int price);
        public int IncBudget(int price);
        public bool Login();

    }
}
