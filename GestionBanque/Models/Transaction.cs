namespace GestionBanque.Models
{
    public class Transaction
    {
        public string TransactionId { get; set; }
        public string AccountId { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionType { get; set; } // e.g., Deposit, Withdrawal, Transfer
        public string Description { get; set; }
    }
}