using LetsConnect.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace LetsConnect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LetsConnectController : ControllerBase
    {
        private readonly LetsConnectDbContext _letsConnectDbContext;
        public LetsConnectController(LetsConnectDbContext letsConnectDbContext)
        {
            _letsConnectDbContext = letsConnectDbContext;
        }
        [HttpGet("GetEmployees")]
        public IActionResult GetUsers()
        {
            var query = (from user in _letsConnectDbContext.Users
                               select user).ToList();
            return Ok(query);
        }
    }
}
