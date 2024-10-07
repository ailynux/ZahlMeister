namespace PayMon.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = null!; // Non-nullable
        public string Email { get; set; } = null!; // Non-nullable
        public string PasswordHash { get; set; } = null!; // Non-nullable
    }
}
