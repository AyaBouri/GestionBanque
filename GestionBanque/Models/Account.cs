namespace GestionBanque.Models
{
    public class Account
    {
        public string AccountId { get; set; }
        public string ClientId { get; set; }
        public string AccountType { get; set; } // "Checking", "Savings", etc.
        public decimal Balance { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
        public RIB RIB { get; set; } // Détails RIB liés
    }
}