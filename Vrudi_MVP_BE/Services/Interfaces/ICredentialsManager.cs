namespace Vrudi_MVP_BE.Services.Interfaces
{
    public interface ICredentialsManager
    {
        public string Authenticate(string email, string password);

    }
}
