﻿using StudentCourseApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourseApp.Application.Interfaces.Repository
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<Product> test(Product product);
    }
}
