namespace Vrudi_MVP_BE.Repositories.Interfaces
{
    public interface ICredentialRepository
    {
        bool ValidateCredentials(string username, string password);
    }
}
