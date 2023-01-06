using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentCourseApp.Domain.Entities;

namespace StudentCourseApp.Persistence.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasOne(x => x.StudentClass).WithMany(x => x.Students).HasForeignKey(x => x.StudentClassId).OnDelete(DeleteBehavior.NoAction);
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Surname).IsRequired();
        }
    }
}
