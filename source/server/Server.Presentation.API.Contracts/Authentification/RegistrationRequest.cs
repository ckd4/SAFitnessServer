namespace Server.Presentation.Contracts.Authentification
{
    public sealed class RegistrationRequest
    {
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;

        // TODO:
        // * specify additional fields for request
    }
}
