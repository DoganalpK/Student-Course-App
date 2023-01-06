using AutoMapper;
using MediatR;
using StudentCourseApp.Application.Interfaces.Repository;
using StudentCourseApp.Application.Wrappers;
using StudentCourseApp.Application.Wrappers.Enums;
using StudentCourseApp.Domain.Entities;

namespace StudentCourseApp.Application.Features.Commands.StudentCommands.UpdateStudent
{
    public class UpdateStudentCommandHandler : IRequestHandler<UpdateStudentCommandRequest, IResponse>
    {
        private readonly IGenericRepository<Student> _repository;
        private readonly IMapper _mapper;

        public UpdateStudentCommandHandler(IGenericRepository<Student> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IResponse> Handle(UpdateStudentCommandRequest request, CancellationToken cancellationToken)
        {
            var unchanged = await _repository.GetByIdAsync(request.Id);
            var requestDto = _mapper.Map<Student>(request);
            await _repository.UpdateAsync(requestDto, unchanged);
            return new Response(ResponseType.Success);
        }
    }
}
