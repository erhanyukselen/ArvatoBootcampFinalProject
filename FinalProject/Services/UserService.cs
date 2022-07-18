using FinalProject.Entities;

namespace FinalProject.Services
{
    public interface UserService
    {
        public User GetUser(string Username, string Password);
    }
}
