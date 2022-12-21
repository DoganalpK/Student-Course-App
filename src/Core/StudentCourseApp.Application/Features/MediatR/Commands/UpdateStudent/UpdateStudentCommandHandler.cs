using AutoMapper;
using MediatR;
using StudentCourseApp.Application.Dtos;
using StudentCourseApp.Application.Interfaces.Repository;
using StudentCourseApp.Application.Wrappers;

namespace StudentCourseApp.Application.Features.MediatR.Commands.UpdateStudent
{
    public class UpdateStudentCommandHandler : IRequestHandler<UpdateStudentCommandRequest, Response<StudentDto>>
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;

        public UpdateStudentCommandHandler(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        public Task<Response<StudentDto>> Handle(UpdateStudentCommandRequest request, CancellationToken cancellationToken)
        {
            //update student
            throw new NotImplementedException();
        }
    }
}
