namespace GestionBanque.Models
{
    public class prêt_bancaire
    {
        private string LoanId { get; set; }
        private string UserId { get; set; }
        private decimal LoanAmount { get; set; }
        private decimal InterestRate { get; set; }
        private DateTime LoanStartDate { get; set; }
        private DateTime LoanEndDate { get; set; }
        private bool IsPaid { get; set; }
    }
}