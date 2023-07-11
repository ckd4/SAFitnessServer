namespace Server.Presentation.Contracts.Authentification
{
    public sealed record RegistrationRequest
    {
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;

        // TODO:
        // * specify additional fields for request
    }
}
