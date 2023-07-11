namespace Server.Presentation.Contracts.Authentification
{
    public sealed record LoginRequest
    {
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
