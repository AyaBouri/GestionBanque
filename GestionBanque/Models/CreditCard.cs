namespace GestionBanque.Models
{
    public class CreditCard
    {
        private string CardId { get; set; }
        private string UserId { get; set; }
        private string CardNumber { get; set; }
        private DateTime ExpiryDate { get; set; }
        private decimal CreditLimit { get; set; }
        private decimal Balance { get; set; }
    }
}