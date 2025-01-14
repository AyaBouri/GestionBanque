namespace GestionBanque.Models
{
    public class Deposit
    {
        private string DepositId { get; set; }
        private string ClientId { get; set; }
        private string AccountId { get; set; }
        private decimal Amount { get; set; }
        private string ChequeNumber { get; set; } // Null si dépôt en espèces
        private DateTime DepositDate { get; set; }
        private string ReceiptId { get; set; } // Lien avec le reçu
    }
}