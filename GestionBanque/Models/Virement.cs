namespace GestionBanque.Models
{
    public class Virement
    {
        private string TransferId { get; set; }
        private string SenderAccountId { get; set; }
        private string SenderClientId { get; set; }
        private string ReceiverAccountId { get; set; }
        private string ReceiverClientId { get; set; }
        private decimal Amount { get; set; }
        private DateTime TransferDate { get; set; }
        private string Description { get; set; } // Optionnel : détails sur le virement
        private string ReceiptId { get; set; } // Lien avec le reçu généré
    }
}