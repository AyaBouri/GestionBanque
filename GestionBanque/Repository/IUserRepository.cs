using GestionBanque.Models;
namespace GestionBanque.Repository
{
    public interface IUserRepository
    {
        User GetUserByEmail(string email);
        void CreateUser(User user);
        bool CheckIfUserExists(string email);
    }
}