using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StudentCourseApp.Application.Interfaces.Repository;
using StudentCourseApp.Application.Interfaces.UnitOfWork;
using StudentCourseApp.Persistence.Contexts;
using StudentCourseApp.Persistence.Repositories;
using StudentCourseApp.Persistence.UnitOfWork;

namespace StudentCourseApp.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(opt =>
            {
                opt.UseInMemoryDatabase("memoryDb");
            });

            services.AddScoped<IUow, Uow>();
            services.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}
