using MediatR;
using StudentCourseApp.Application.Wrappers;

namespace StudentCourseApp.Application.Features.MediatR.Commands.CreateStudentClass
{
    public class CreateStudentClassCommandHandler : IRequestHandler<CreateStudentClassCommandRequest, IResponse>
    {
        public Task<IResponse> Handle(CreateStudentClassCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
