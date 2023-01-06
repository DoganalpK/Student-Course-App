using FluentValidation;

namespace StudentCourseApp.Application.Features.Commands.StudentCommands.CreateStudent
{
    public class CreateStudentCommandValidator : AbstractValidator<CreateStudentCommandRequest>
    {
        public CreateStudentCommandValidator()
        {
            RuleFor(x => x.StudentClassId)
                .NotEmpty()
                .WithMessage("Öğrenci sınıfı boş geçilemez.");

            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Öğrenci adı boş geçilemez.")
                .NotNull().WithMessage("Öğrenci adı boş geçilemez.");
        }
    }
}
