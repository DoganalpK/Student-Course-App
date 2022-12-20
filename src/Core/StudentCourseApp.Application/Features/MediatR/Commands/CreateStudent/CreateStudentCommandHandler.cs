using AutoMapper;
using MediatR;
using StudentCourseApp.Application.Dtos;
using StudentCourseApp.Application.Interfaces.Repository;
using StudentCourseApp.Application.Wrappers;
using StudentCourseApp.Application.Wrappers.Enums;
using StudentCourseApp.Domain.Entities;

namespace StudentCourseApp.Application.Features.MediatR.Commands.CreateStudent
{
    public class CreateStudentCommandHandler : IRequestHandler<CreateStudentCommandRequest, IResponse<StudentDto>>
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;

        public CreateStudentCommandHandler(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        public async Task<IResponse<StudentDto>> Handle(CreateStudentCommandRequest request, CancellationToken cancellationToken)
        {
            var dto = _mapper.Map<Student>(request);
            await _studentRepository.AddAsync(dto);
            return new Response<StudentDto>(ResponseType.Success, _mapper.Map<StudentDto>(request));
        }
    }
}
