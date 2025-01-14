namespace GestionBanque.Models
{
    public class Deposit
    {
        public string DepositId { get; set; }
        public string ClientId { get; set; }
        public string AccountId { get; set; }
        public decimal Amount { get; set; }
        public string ChequeNumber { get; set; } // Null si dépôt en espèces
        public DateTime DepositDate { get; set; }
        public string ReceiptId { get; set; } // Lien avec le reçu
    }
}