using GestionBanque.Models;
using GestionBanque.Repository;
namespace GestionBanque.Service
{
    public class UserService:IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public string Login(string email, string password)
        {
            var user = _userRepository.GetUserByEmail(email);
            if (user == null || !BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
            {
                throw new Exception("Invalid credentials");
            }

            // Générer un token (exemple de logique fictive pour simplifier)
            return "FakeJWTTokenFor_" + user.Email;
        }

        public void Register(User user)
        {
            if (_userRepository.CheckIfUserExists(user.Email))
            {
                throw new Exception("User already exists");
            }

            // Hashage du mot de passe
            user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(user.PasswordHash);
            _userRepository.CreateUser(user);
        }
    }
}