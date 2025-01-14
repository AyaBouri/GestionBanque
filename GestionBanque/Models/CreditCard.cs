namespace GestionBanque.Models
{
    public class CreditCard
    {
        public string CardId { get; set; }
        public string UserId { get; set; }
        public string CardNumber { get; set; }
        public DateTime ExpiryDate { get; set; }
        public decimal CreditLimit { get; set; }
        public decimal Balance { get; set; }
    }
}