using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentCourseApp.Domain.Entities;

namespace StudentCourseApp.Persistence.Configurations
{
    public class StudentClassConfiguration : IEntityTypeConfiguration<StudentClass>
    {
        public void Configure(EntityTypeBuilder<StudentClass> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.ClassNumber).IsRequired();
        }
    }
}
