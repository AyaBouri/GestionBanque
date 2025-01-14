namespace GestionBanque.Models
{
    public class User
    {
        private string Id { get; set; }
        private string UserName { get; set; }
        private string Email { get; set; }
        private string Phone { get; set; }
        private string City { get; set; }
        private string Country { get; set; }
        private string Gender { get; set; }
        private string Identity { get; set; }
        private List<Account> Accounts { get; set; }
    }
}