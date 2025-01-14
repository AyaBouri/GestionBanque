namespace GestionBanque.Models
{
    public class Account
    {
        private string AccountId { get; set; }
        private string ClientId { get; set; }
        private string AccountType { get; set; } // "Checking", "Savings", etc.
        private decimal Balance { get; set; }
        private DateTime CreatedDate { get; set; }
        private bool IsActive { get; set; }
        private RIB RIB { get; set; } // Détails RIB liés
    }
}