namespace GestionBanque.Models
{
    public class RIB
    {
        public string RIBId { get; set; }
        public int AccountId { get; set; }
        public string IBAN { get; set; }
        public string SwiftCode { get; set; }
        public string BankName { get; set; }
        public string BranchName { get; set; }

        // Propriété de navigation (si nécessaire)
        public Account Account { get; set; }
    }
}
