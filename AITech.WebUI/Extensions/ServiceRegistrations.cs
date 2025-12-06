using AITech.WebUI.Services.AboutItemServices;
using AITech.WebUI.Services.AboutServices;
using AITech.WebUI.Services.BannerServices;
using AITech.WebUI.Services.CategoryServices;
using AITech.WebUI.Services.ChooseServices;
using AITech.WebUI.Services.ContactServices;
using AITech.WebUI.Services.GeminiServices;
using AITech.WebUI.Services.ProjectServices;
using FluentValidation;
using FluentValidation.AspNetCore;
using System.Reflection;

namespace AITech.WebUI.Extensions
{
    public static class ServiceRegistrations
    {
        public static void AddUIServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<IBannerService, BannerService>();
            services.AddScoped<IGeminiService, GeminiService>();
            services.AddScoped<IAboutService, AboutService>();
            services.AddScoped<IAboutItemService, AboutItemService>();
            services.AddScoped<IChooseService, ChooseService>();
            services.AddScoped<IContactService, ContactService>();

            services.AddFluentValidationAutoValidation()
                .AddFluentValidationClientsideAdapters()
                .AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

        }
    }
}
