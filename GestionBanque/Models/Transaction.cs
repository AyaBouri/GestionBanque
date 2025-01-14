namespace GestionBanque.Models
{
    public class Transaction
    {
        private string TransactionId { get; set; }
        private string AccountId { get; set; }
        private decimal Amount { get; set; }
        private DateTime TransactionDate { get; set; }
        private string TransactionType { get; set; } // e.g., Deposit, Withdrawal, Transfer
        private string Description { get; set; }
    }
}