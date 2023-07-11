namespace Server.Presentation.Contracts.Authentification
{
    public sealed class LoginRequest
    {
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
