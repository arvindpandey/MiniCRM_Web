namespace MiniCRM.Core.Entities
{
    public class Users
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }    
        public string Email { get; set; }   
        public string Role { get; set; } // e.g., Admin, User   
        public DateTime CreatedAt { get; set; } 

    }
}
