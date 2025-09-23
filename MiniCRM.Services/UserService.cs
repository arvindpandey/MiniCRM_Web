using MiniCRM.Core.Interfaces.Repositories;
using MiniCRM.Infrastructure.Entities;
using MiniCRM.Services.Interfaces;
using System.Security.Cryptography;
using System.Text;

namespace MiniCRM.Services
{
    public class UserService :IUserService
    {
        private readonly IRepository<User> _repository;

        public UserService(IRepository<User> repository) 
        {
            _repository = repository;
        }
        
        public async Task<User?> AuthenticateAsync(string username, string password)
        {
            var users = await _repository.GetAllAsync();
            var passwordHash = ComputeHash(password);
            return  users.FirstOrDefault(u => u.UserName == username && u.PasswordHash == passwordHash); 

        } 
        public Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return _repository.GetAllAsync();
        }
        public async Task<User> AddUserAsync(User user)
        {
            var passwordHash = ComputeHash(user.PasswordHash);
            user.PasswordHash = passwordHash;
            await _repository.AddAsync(user);
            await _repository.SaveChangesAsync();   
            return user;

        }
        private string ComputeHash(string input)
        {
            using var sha256 = SHA256.Create();
            var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
            return Convert.ToBase64String(bytes);
        }
    }
}
