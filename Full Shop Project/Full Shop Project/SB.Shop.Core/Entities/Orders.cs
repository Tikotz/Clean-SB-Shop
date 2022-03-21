using System;

namespace Full_Shop_Project.SB.Shop.Core
{
    public class Orders
    {
        public int OrderId { get; set; }
        public int? CustomerId { get; set; }
        public DateTime? OrderDate { get; set; }

        public virtual User Customer { get; set; }

    }
}