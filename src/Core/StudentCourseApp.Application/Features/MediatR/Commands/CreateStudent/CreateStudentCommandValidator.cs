using FluentValidation;

namespace StudentCourseApp.Application.Features.MediatR.Commands.CreateStudent
{
    public class CreateStudentCommandValidator : AbstractValidator<CreateStudentCommandRequest>
    {
        public CreateStudentCommandValidator()
        {
            RuleFor(x => x.StudentClassId).NotEmpty().WithMessage("Öğrenci sınıf bilgisi boş geçilemez.");
        }
    }
}
