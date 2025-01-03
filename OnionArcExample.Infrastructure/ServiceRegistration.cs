using Microsoft.Extensions.DependencyInjection;
using OnionArcExample.Infrastructure.Interfaces.Services;


namespace OnionArcExample.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IEmailService, EmailService>();
        }
    }
}
