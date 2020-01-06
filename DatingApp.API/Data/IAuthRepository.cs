using System.Threading.Tasks;
using DatingApp.API.Models;

namespace DatingApp.API.Data
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string passoword);
        Task<User> Login (string username, string passoword);
        Task<bool> UserExists(string username);
    }
}