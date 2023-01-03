using AutoMapper;
using MediatR;
using StudentCourseApp.Application.Dtos;
using StudentCourseApp.Application.Interfaces.Repository;
using StudentCourseApp.Application.Wrappers;
using StudentCourseApp.Application.Wrappers.Enums;

namespace StudentCourseApp.Application.Features.MediatR.Queries.GetAllStudents
{
    public class GetAllStudentsQueryHandler : IRequestHandler<GetAllStudentsQueryRequest, IResponse<List<StudentDto>>>
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;

        public GetAllStudentsQueryHandler(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository; 
            _mapper = mapper;
        }

        public async Task<IResponse<List<StudentDto>>> Handle(GetAllStudentsQueryRequest request, CancellationToken cancellationToken)
        {
            var students = await _studentRepository.GetAllAsync();
            var dto = _mapper.Map<List<StudentDto>>(students);
            return new Response<List<StudentDto>>(ResponseType.Success, dto);
        }
    }
}
