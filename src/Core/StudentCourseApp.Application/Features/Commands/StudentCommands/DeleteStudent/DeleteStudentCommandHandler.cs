using MediatR;
using StudentCourseApp.Application.Interfaces.Repository;
using StudentCourseApp.Application.Wrappers;
using StudentCourseApp.Application.Wrappers.Enums;
using StudentCourseApp.Domain.Entities;

namespace StudentCourseApp.Application.Features.Commands.StudentCommands.DeleteStudent
{
    public class DeleteStudentCommandHandler : IRequestHandler<DeleteStudentCommandRequest, IResponse>
    {
        private readonly IGenericRepository<Student> _repository;

        public DeleteStudentCommandHandler(IGenericRepository<Student> repository)
        {
            _repository = repository;
        }

        public async Task<IResponse> Handle(DeleteStudentCommandRequest request, CancellationToken cancellationToken)
        {
            await _repository.RemoveAsync(request.Id);
            return new Response(ResponseType.Success);
        }
    }
}
