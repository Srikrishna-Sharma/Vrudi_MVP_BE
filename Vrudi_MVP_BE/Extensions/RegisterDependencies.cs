using Vrudi_MVP_BE.Services.Classes;
using Vrudi_MVP_BE.Services.Interfaces;

namespace Vrudi_MVP_BE.Extensions
{
    public static  class RegisterDependencies
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services)
        {
            services.AddTransient<ICredentialsManager, CredentialsManager>();

            return services;
        }

    }
}
