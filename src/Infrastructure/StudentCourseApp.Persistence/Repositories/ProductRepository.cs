using StudentCourseApp.Application.Interfaces.Repository;
using StudentCourseApp.Domain.Entities;
using StudentCourseApp.Persistence.Contexts;

namespace StudentCourseApp.Persistence.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }

        public Task<Product> test(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
