using System.Text.RegularExpressions;

namespace GestionBanque.Validation
{
    public class DataValidation:IDataValidation
    {
        public bool ValidateEmail(string email)
        {
            if (string.IsNullOrEmpty(email)) return false;
            var emailRegex = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailRegex);
        }

        // Validation du téléphone
        public bool ValidatePhone(string phone)
        {
            if (string.IsNullOrEmpty(phone)) return false;
            var phoneRegex = @"^\+?\d{10,15}$"; // Supporte les numéros avec indicatif international
            return Regex.IsMatch(phone, phoneRegex);
        }

        // Validation du montant
        public bool ValidateAmount(decimal amount)
        {
            return amount > 0;
        }

        // Validation du RIB
        public bool ValidateRIB(string rib)
        {
            if (string.IsNullOrEmpty(rib) || rib.Length != 24) return false; // Ex: Longueur RIB = 24 (standard IBAN)
            return Regex.IsMatch(rib, @"^[A-Z0-9]+$");
        }

        // Validation du rôle (Admin, Client, Employé)
        public bool ValidateRole(string role)
        {
            var validRoles = new[] { "Admin", "Client", "Employe" };
            return validRoles.Contains(role);
        }

        // Validation des données d'un client
        public bool ValidateClientData(string fullName, string email, string phone, string role)
        {
            if (string.IsNullOrWhiteSpace(fullName)) return false;
            if (!ValidateEmail(email)) return false;
            if (!ValidatePhone(phone)) return false;
            if (!ValidateRole(role)) return false;
            return true;
        }
    }
}