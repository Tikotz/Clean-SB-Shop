namespace Full_Shop_Project.SB.Shop.Core
{
    public class Product
    {
        public int ProductId { get; set; }
        public int CompanyId { get; set; }
        public string ProductName { get; set; }
        public int? UnitPrice { get; set; }
        public int? UnitInStock { get; set; }

    }
}