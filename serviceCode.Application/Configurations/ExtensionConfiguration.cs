using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using serviceCode.Domain.Config;

namespace serviceCode.Application.Configurations
{

    public static class ExtensionConfiguration
    {

        public static IServiceCollection AddCustomConfiguration(
            this IServiceCollection services,
            ConfigurationManager configuration)
        {

            var books = new List<Book>();
            var x =configuration.GetSection("bookList");
            services.Configure<BookList>(configuration.GetSection("bookList"));

            return services;
        }
    }
}