using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace StudentCourseApp.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            var assmb = Assembly.GetExecutingAssembly();
            services.AddAutoMapper(assmb);
            services.AddMediatR(assmb);
        }
    }
}
