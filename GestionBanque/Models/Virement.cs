namespace GestionBanque.Models
{
    public class Virement
    {
        public string TransferId { get; set; }
        public string SenderClientId { get; set; }
        public string ReceiverClientId { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransferDate { get; set; }
        public string Description { get; set; } // Optionnel : détails sur le virement
        public string ReceiptId { get; set; } // Lien avec le reçu généré
        public Account SenderAccount { get; set; }
        public Account ReceiverAccount { get; set; }
    }
}