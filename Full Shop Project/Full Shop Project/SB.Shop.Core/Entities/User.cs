namespace Full_Shop_Project.SB.Shop.Core
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Budget { get; set; }
        public string IsLogin { get; set; }
        public bool IsAdmin { get; set; }
    }
}