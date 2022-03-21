using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Full_Shop_Project.SB.Shop.Core.Interfaces
{
    internal interface IProduct
    {
        public string GetProductName();
        public int GetProductId();
        public int GetProductPrice();
        public int GetProductUIStock();
        public int SetProductUIStock();

    }
}
