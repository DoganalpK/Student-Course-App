using AutoMapper;
using MediatR;
using StudentCourseApp.Application.Interfaces.Repository;
using StudentCourseApp.Application.Wrappers;
using StudentCourseApp.Application.Wrappers.Enums;
using StudentCourseApp.Domain.Entities;

namespace StudentCourseApp.Application.Features.Commands.StudentCommands.CreateStudent
{
    public class CreateStudentCommandHandler : IRequestHandler<CreateStudentCommandRequest, IResponse>
    {
        private readonly IGenericRepository<Student> _repository;
        private readonly IMapper _mapper;

        public CreateStudentCommandHandler(IGenericRepository<Student> reposity, IMapper mapper)
        {
            _repository = reposity;
            _mapper = mapper;
        }

        public async Task<IResponse> Handle(CreateStudentCommandRequest request, CancellationToken cancellationToken)
        {
            var requestDto = _mapper.Map<Student>(request);
            var data = await _repository.AddAsync(requestDto);
            var dto = _mapper.Map<CreateStudentDto>(data);
            return new Response<CreateStudentDto>(ResponseType.Success, dto);
        }

    }
}
