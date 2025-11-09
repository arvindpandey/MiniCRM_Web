using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiniCRM.Core.Interfaces.Repositories;
using MiniCRM.Infrastructure.Entities;
using MiniCRM.Services.Interfaces;

namespace MiniCRM_Web.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _iuserService;

        public UserController(IUserService repository)
        {
            _iuserService = repository;
        }
        public async Task<IActionResult> GetAllUsersAsync()
        {
            var users = await _iuserService.GetAllUsersAsync();
            return Ok(users);
        }
        public async Task<IActionResult> AddUserAsync(User user)
        {
            var newUser = await _iuserService.AddUserAsync(user);
            return Ok(newUser);
        }
        public async Task<IActionResult> AuthenticateAsync(string username, string password)
        {
            var user = await _iuserService.AuthenticateAsync(username, password);
            if (user == null)
            {
                return Unauthorized();
            }
            return Ok(user);
        }
    }
}
