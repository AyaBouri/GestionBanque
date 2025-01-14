using GestionBanque.Models;

namespace GestionBanque.Repository
{
    public class UserRepository:IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public User GetUserByEmail(string email)
        {
            return _context.users.FirstOrDefault(u => u.Email == email);
        }

        public void CreateUser(User user)
        {
            _context.users.Add(user);
            _context.SaveChanges();
        }

        public bool CheckIfUserExists(string email)
        {
            return _context.users.Any(u => u.Email == email);
        }
    }
}