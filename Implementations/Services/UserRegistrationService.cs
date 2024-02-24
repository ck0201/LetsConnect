using LetsConnect.Interfaces.Services;
using LetsConnect.Models.UserRegistration;
using LetsConnect.Repository;
using LetsConnect.Repository.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace LetsConnect.Implementations.Services
{
    public class UserRegistrationService : IUserRegistrationService
    {
        private readonly LetsConnectDbContext _letsConnectDbContext;
        public UserRegistrationService(LetsConnectDbContext letsConnectDbContext)
        {
            _letsConnectDbContext = letsConnectDbContext;
        }

        public async Task<bool> CreateUser(UserDetails userDetails)
        {
            var userData = new User
            {
                UserLoginId = userDetails.UserLoginId,
                UserPassword = userDetails.UserPassword,
                FirstName = userDetails.FirstName,
                LastName = userDetails.LastName,
                Email = userDetails.Email,
                PhoneNo = userDetails.PhoneNo,
                MiddleName = userDetails.MiddleName,
                CreationDate = DateTime.Now,
                Gender = userDetails.Gender,
                //Dob = userDetails.DOB,
            };
            await _letsConnectDbContext.AddAsync(userData);
            await _letsConnectDbContext.SaveChangesAsync();
            var query = await (from user in _letsConnectDbContext.Users
                         select user).ToListAsync();
            return true;
        }
    }
}
