using LetsConnect.Interfaces.Services;
using LetsConnect.Models.UserRegistration;
using Microsoft.AspNetCore.Mvc;

namespace LetsConnect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LetsConnectController : ControllerBase
    {
        private readonly IUserRegistrationService _userRegistrationService;
        public LetsConnectController(IUserRegistrationService userRegistrationService)
        {
            _userRegistrationService = userRegistrationService;
        }
        [HttpPost("GetEmployees")]
        public async Task<IActionResult> CreateUserAsync(UserDetails userDetails)
        {
            bool IsSaved = await _userRegistrationService.CreateUser(userDetails);
            return Ok(IsSaved);
        }
    }
}
