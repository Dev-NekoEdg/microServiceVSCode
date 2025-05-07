using Microsoft.Extensions.DependencyInjection;
using serviceCode.Application.Services.Book;

namespace serviceCode.Application.Configurations
{

    public static class ServicesConfiguration
    {
        public static IServiceCollection AddCustomServices(this IServiceCollection services)
        {
            services.AddTransient<IBookService, BookService>();
            return services;
        }

    }

}