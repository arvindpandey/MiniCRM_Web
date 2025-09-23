using MiniCRM.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCRM.Services.Interfaces
{
    public interface IUserService
    {
        Task<User?> AuthenticateAsync (string username, string password);   
        Task<IEnumerable<User>> GetAllUsersAsync ();
        Task<User> AddUserAsync (User user);
        
    }
}
