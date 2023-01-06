using AutoMapper;
using MediatR;
using StudentCourseApp.Application.Dtos;
using StudentCourseApp.Application.Interfaces.Repository;
using StudentCourseApp.Application.Wrappers;
using StudentCourseApp.Application.Wrappers.Enums;
using StudentCourseApp.Domain.Entities;

namespace StudentCourseApp.Application.Features.Queries.StudentQueries.GetAllStudents
{
    public class GetAllStudentsQueryHandler : IRequestHandler<GetAllStudentsQueryRequest, IResponse<List<StudentDto>>>
    {
        private readonly IGenericRepository<Student> _repository;
        private readonly IMapper _mapper;

        public GetAllStudentsQueryHandler(IGenericRepository<Student> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IResponse<List<StudentDto>>> Handle(GetAllStudentsQueryRequest request, CancellationToken cancellationToken)
        {
            var students = await _repository.GetAllAsync();
            var dto = _mapper.Map<List<StudentDto>>(students);
            return new Response<List<StudentDto>>(ResponseType.Success, dto);
        }
    }
}
