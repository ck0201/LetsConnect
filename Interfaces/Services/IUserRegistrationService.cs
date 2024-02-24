using LetsConnect.Models.UserRegistration;

namespace LetsConnect.Interfaces.Services
{
    public interface IUserRegistrationService
    {
        public Task<bool> CreateUser(UserDetails userDetails);
    }
}
