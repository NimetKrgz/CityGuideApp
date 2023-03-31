using Azure.Identity;
using CityGuideAPIV1.Models;

namespace CityGuideAPIV1.Data
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string password);
        Task<User> Login(string userName, string password);
        Task<bool> UserExists (string userName);
    }
}
