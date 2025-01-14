namespace GestionBanque.Models
{
    public class User
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Gender { get; set; }
        public string Identity { get; set; }
        public List<Account> Accounts { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; internal set; }
    }
}