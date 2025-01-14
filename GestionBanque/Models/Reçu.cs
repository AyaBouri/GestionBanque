namespace GestionBanque.Models
{
    public class Reçu
    {
        private string ReceiptId { get; set; }
        private string TransactionId { get; set; }
        private DateTime DateIssued { get; set; }
        private decimal Amount { get; set; }
        private string Description { get; set; } // Exemple: "Dépôt de chèque", "Virement bancaire", etc.
    }
}