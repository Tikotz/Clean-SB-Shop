using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Full_Shop_Project.SB.Shop.Core.Interfaces
{
    internal interface IOrders
    {
        public int GetOrderID();
        public DateTime GetOrderDate(int orderId);
    }
}
