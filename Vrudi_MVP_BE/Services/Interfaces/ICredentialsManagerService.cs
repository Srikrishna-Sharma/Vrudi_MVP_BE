namespace Vrudi_MVP_BE.Services.Interfaces
{
    public interface ICredentialsManagerService
    {
        public string Authenticate(string email, string password);

    }
}
