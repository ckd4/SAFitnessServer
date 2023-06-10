namespace Server.Core.Application.Services
{
    public sealed class AuthentificationService : IAuthentificationService
    {
        public async Task GetUserData(string token)
        {
            await Task.Run(() => { });
        }
        public async Task Login(string username, string password)
        {
            await Task.Run(() => { });
        }
        public async Task Register(string username, string password, string firstName, string lastName)
        {
            await Task.Run(() => { });
        }
    }
}
