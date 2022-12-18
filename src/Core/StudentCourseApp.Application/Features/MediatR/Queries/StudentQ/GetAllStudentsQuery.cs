using AutoMapper;
using MediatR;
using StudentCourseApp.Application.Dtos;
using StudentCourseApp.Application.Interfaces.Repository;
using StudentCourseApp.Application.Interfaces.UnitOfWork;
using StudentCourseApp.Application.Wrappers;
using StudentCourseApp.Domain.Entities;

namespace StudentCourseApp.Application.Features.MediatR.Queries.StudentQ
{
    public class GetAllStudentsQuery : IRequest<ServiceResponse<List<StudentDto>>>
    {
        public class GetAllStudentsHandler : IRequestHandler<GetAllStudentsQuery, ServiceResponse<List<StudentDto>>>
        {
            private readonly IStudentRepository _studentRepository;
            private readonly IMapper _mapper;

            public GetAllStudentsHandler(IStudentRepository studentRepository, IMapper mapper)
            {
                _studentRepository = studentRepository;
                _mapper = mapper;
            }

            public async Task<ServiceResponse<List<StudentDto>>> Handle(GetAllStudentsQuery request, CancellationToken cancellationToken)
            {
                var students = await _studentRepository.GetAllAsync();
                var dto = _mapper.Map<List<StudentDto>>(students);
                return new ServiceResponse<List<StudentDto>>(dto);
            }
        }
    }
}
