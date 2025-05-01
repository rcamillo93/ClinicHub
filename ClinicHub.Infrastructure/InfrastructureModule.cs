using ClinicHub.Core.Repositores;
using ClinicHub.Infrastructure.Persistence;
using ClinicHub.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ClinicHub.Infrastructure
{
    public static class InfrastructureModule
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddRepositories(configuration);

            return services;
        }

        private static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ClinicHubDbContext>(
                options => options.UseSqlServer(configuration.GetConnectionString("ClinicHub")));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IUserRepository, UserRepository>();           
            services.AddScoped<IConsultationTypeRepository, ConsultationTypeRepository>();
            services.AddScoped<CustomerServiceRepository, CustomerServiceRepository>();
            services.AddScoped<IHealthInsuranceRepository, HealthInsuranceRepository>();
            services.AddScoped<IPatientRepository, PatientRepository>();
            services.AddScoped<IServiceRepository, ServiceRepository>();
            services.AddScoped<ISpecialtyRepository, SpecialtyRepository>();

            return services;
        }
    }
}