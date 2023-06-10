namespace Server.Core.Application.Services
{
    public interface IAuthentificationService
    {
        Task Login(string username, string password);
        Task Register(string username, string password, string firstName, string lastName);
        Task GetUserData(string token);
    }
}
