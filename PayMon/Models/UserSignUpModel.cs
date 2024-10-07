namespace PayMon.Models
{
    public class UserSignUpModel
    {
        public string Username { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!; // Ensure this matches the user password input
    }
}
