namespace TMS.Entity
{
    public class UserCredentials
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class ValidateUserTokenVM
    {
        public string Token { get; set; }
        public int TokenType { get; set; }
    }

    public class SetPasswordVM
    {
        public string Token { get; set; }
        public string Password { get; set; }
        public int TokenType { get; set; }
    }
}
