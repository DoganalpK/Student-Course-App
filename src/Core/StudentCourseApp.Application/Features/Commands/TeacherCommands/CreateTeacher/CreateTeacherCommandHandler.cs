using AutoMapper;
using MediatR;
using StudentCourseApp.Application.Interfaces.Repository;
using StudentCourseApp.Application.Wrappers;
using StudentCourseApp.Application.Wrappers.Enums;
using StudentCourseApp.Domain.Entities;

namespace StudentCourseApp.Application.Features.Commands.TeacherCommands.CreateTeacher
{
    public class CreateTeacherCommandHandler : IRequestHandler<CreateTeacherCommandRequest, IResponse>
    {
        private readonly IGenericRepository<Teacher> _repository;
        private readonly IMapper _mapper;

        public CreateTeacherCommandHandler(IGenericRepository<Teacher> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IResponse> Handle(CreateTeacherCommandRequest request, CancellationToken cancellationToken)
        {
            var dto = _mapper.Map<Teacher>(request);
            var data = await _repository.AddAsync(dto);
            return new Response(ResponseType.Success);
        }
    }
}
