using AutoMapper;
using MediatR;
using StudentCourseApp.Application.Interfaces.Repository;
using StudentCourseApp.Application.Wrappers;
using StudentCourseApp.Application.Wrappers.Enums;
using StudentCourseApp.Domain.Entities;

namespace StudentCourseApp.Application.Features.MediatR.Commands.UpdateStudent
{
    public class UpdateStudentCommandHandler : IRequestHandler<UpdateStudentCommandRequest, IResponse>
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;

        public UpdateStudentCommandHandler(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        public async Task<IResponse> Handle(UpdateStudentCommandRequest request, CancellationToken cancellationToken)
        {
            var unchanged = await _studentRepository.GetByIdAsync(request.Id);
            var requestDto = _mapper.Map<Student>(request);
            await _studentRepository.UpdateAsync(requestDto, unchanged);
            return new Response(ResponseType.Success);
        }
    }
}
