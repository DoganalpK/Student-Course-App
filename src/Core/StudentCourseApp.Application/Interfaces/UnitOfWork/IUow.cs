using StudentCourseApp.Application.Interfaces.Repository;
using StudentCourseApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourseApp.Application.Interfaces.UnitOfWork
{
    public interface IUow
    {
        IGenericRepository<T> GetRepository<T>() where T : BaseEntity;
        Task SaveChangesAsync();
    }
}
