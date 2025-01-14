namespace GestionBanque.Models
{
    public class Reçu
    {
        public string ReceiptId { get; set; }
        public string TransactionId { get; set; }
        public DateTime DateIssued { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; } // Exemple: "Dépôt de chèque", "Virement bancaire", etc.
    }
}