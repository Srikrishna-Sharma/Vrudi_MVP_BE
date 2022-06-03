using Vrudi_MVP_BE.Repositories.Classes;
using Vrudi_MVP_BE.Repositories.Interfaces;
using Vrudi_MVP_BE.Services.Classes;
using Vrudi_MVP_BE.Services.Interfaces;

namespace Vrudi_MVP_BE.Extensions
{
    public static  class RegisterDependencies
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services)
        {
            services.AddTransient<ICredentialsManagerService, CredentialsManagerService>();
            services.AddTransient<ICredentialRepository, CredentialRepository>();

            return services;
        }

    }
}
