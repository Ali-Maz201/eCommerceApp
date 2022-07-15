using DapperORM;
using EntityORM.Contexts;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProductFeatures.CreateProductUseCase;
using ProductFeatures.CreateProductUseCase.Validators;
using System.Reflection;

namespace ProductFeatures.Setup
{
    public static class Startup
    {

        public static void AddProductFeatures(this IServiceCollection services, string dbConnection)
        {
            AddNuggets(services);

            AddDatabaseContext(services, dbConnection);

            AddProductUseCase(services);
        }

        private static void AddDatabaseContext(IServiceCollection services, string dbConnection)
        {
            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(dbConnection));
            services.AddScoped<IDapperRepository, DapperRepository>();
        }

        private static void AddNuggets(IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddFluentValidation(options =>
            {
                options.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            });


        }

        private static void AddProductUseCase(IServiceCollection services)
        {
            services.AddScoped<ICreateProduct, CreateProduct>();
            services.AddScoped<IBusinessValidator, BusinessValidator>();
        }
    }
}
