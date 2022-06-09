using Microsoft.Extensions.DependencyInjection;

namespace PaymentMethod.Services
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddPaymentServices(this IServiceCollection services)
        {
            services.AddHttpClient();
            services.AddHttpContextAccessor();
            services.AddSingleton<IPaymentProviderFactory, PaymentProviderFactory>();

            return services;
        }
    }
}