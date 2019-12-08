namespace HayvanDostu.Core.Entity
{
    public abstract class BaseUserEntity : BaseEntity
    {

        public string Username { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string ImagePath1 { get; set; }

    }

}
