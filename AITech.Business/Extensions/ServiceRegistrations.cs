using AITech.Business.Services.AboutItemServices;
using AITech.Business.Services.AboutServices;
using AITech.Business.Services.BannerServices;
using AITech.Business.Services.CategoryServices;
using AITech.Business.Services.ChooseServices;
using AITech.Business.Services.ContactServices;
using AITech.Business.Services.FAQSercives;
using AITech.Business.Services.FeatureServices;
using AITech.Business.Services.ProjectServices;
using AITech.Business.Services.SocialServices;
using Microsoft.Extensions.DependencyInjection;

namespace AITech.Business.Extensions
{
    public static class ServiceRegistrations
    {

        public static void AddBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<IBannerService, BannerService>();
            services.AddScoped<IAboutService, AboutService>();
            services.AddScoped<IAboutItemService, AboutItemService>();
            services.AddScoped<IChooseService, ChooseService>();
            services.AddScoped<IContactService, ContactService>();
            services.AddScoped<IFAQServive, FAQServive>();
            services.AddScoped<IFeatureService, FeatureService>();
            services.AddScoped<ISocialService, SocialService>();
        }
    }
}
