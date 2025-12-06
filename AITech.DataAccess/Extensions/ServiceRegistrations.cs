using AITech.DataAccess.Repositories.AboutItemRepositories;
using AITech.DataAccess.Repositories.AboutRepositories;
using AITech.DataAccess.Repositories.BannerRepositories;
using AITech.DataAccess.Repositories.CategoryRepositories;
using AITech.DataAccess.Repositories.ChooseRepositories;
using AITech.DataAccess.Repositories.ContactRepositories;
using AITech.DataAccess.Repositories.ProjectRepositories;
using AITech.DataAccess.UnitOfWorks;
using Microsoft.Extensions.DependencyInjection;

namespace AITech.DataAccess.Extensions
{
    public static class ServiceRegistrations
    {
        public static void AddDataAccesServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProjectRepository, ProjectRepository>();
            services.AddScoped<IBannerRepository, BannerRepository>();
            services.AddScoped<IAboutRepository, AboutRepository>();
            services.AddScoped<IAboutItemRepository, AboutItemRepository>();
            services.AddScoped<IChooseRepository, ChooseRepository>();
            services.AddScoped<IContactRepository, ContactRepository>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
