using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentCourseApp.Domain.Entities;

namespace StudentCourseApp.Persistence.Configurations
{
    public class LessonConfiguration : IEntityTypeConfiguration<Lesson>
    {
        public void Configure(EntityTypeBuilder<Lesson> builder)
        {
            builder.HasOne(x => x.Teacher).WithMany(x => x.Lessons).HasForeignKey(x => x.TeacherId);
            builder.Property(x => x.Subject).IsRequired();
            builder.Property(x => x.Content).IsRequired();
            builder.Property(x => x.Note).HasMaxLength(250);
            builder.Property(x => x.LessonLevel).IsRequired();
            builder.Property(x => x.TeacherId).IsRequired();
        }
    }
}
