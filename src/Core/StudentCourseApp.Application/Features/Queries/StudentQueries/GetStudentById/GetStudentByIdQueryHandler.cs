using AutoMapper;
using MediatR;
using StudentCourseApp.Application.Dtos;
using StudentCourseApp.Application.Interfaces.Repository;
using StudentCourseApp.Application.Wrappers;
using StudentCourseApp.Application.Wrappers.Enums;
using StudentCourseApp.Domain.Entities;

namespace StudentCourseApp.Application.Features.Queries.StudentQueries.GetStudentById
{
    public class GetStudentByIdQueryHandler : IRequestHandler<GetStudentByIdQueryRequest, IResponse<StudentDto>>
    {
        private readonly IGenericRepository<Student> _repository;
        private readonly IMapper _mapper;

        public GetStudentByIdQueryHandler(IGenericRepository<Student> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IResponse<StudentDto>> Handle(GetStudentByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var student = await _repository.GetByIdAsync(request.Id);
            var dto = _mapper.Map<StudentDto>(student);
            return new Response<StudentDto>(ResponseType.Success, dto);
        }
    }
}
