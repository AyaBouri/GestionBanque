namespace GestionBanque.Validation
{
    public interface IDataValidation
    {
        bool ValidateEmail(string email);
        bool ValidatePhone(string phone);
        bool ValidateAmount(decimal amount);
        bool ValidateRIB(string rib);
        bool ValidateRole(string role);
        bool ValidateClientData(string fullName, string email, string phone, string role);
    }
}