namespace Server.Presentation.Contracts.Authentification
{
    public sealed record LoginResponse
    {
        public string Id { get; set; } = null!;
        public string Username { get; set; } = null!;
        public string Token { get; set; } = null!;

        // TODO:
        // * specify additional field for response
    }
}
