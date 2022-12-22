using MediatR;
using StudentCourseApp.Application.Interfaces.Repository;
using StudentCourseApp.Application.Wrappers;
using StudentCourseApp.Application.Wrappers.Enums;

namespace StudentCourseApp.Application.Features.MediatR.Commands.DeleteStudent
{
    public class DeleteStudentCommandHandler : IRequestHandler<DeleteStudentCommandRequest, IResponse>
    {
        private readonly IStudentRepository _studentRepository;

        public DeleteStudentCommandHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<IResponse> Handle(DeleteStudentCommandRequest request, CancellationToken cancellationToken)
        {
            await _studentRepository.RemoveAsync(request.Id);
            return new Response(ResponseType.Success);
        }
    }
}
