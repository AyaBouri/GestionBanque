namespace GestionBanque.Models
{
    public class prêt_bancaire
    {
        public string LoanId { get; set; }
        public string UserId { get; set; }
        public decimal LoanAmount { get; set; }
        public decimal InterestRate { get; set; }
        public DateTime LoanStartDate { get; set; }
        public DateTime LoanEndDate { get; set; }
        public bool IsPaid { get; set; }
    }
}