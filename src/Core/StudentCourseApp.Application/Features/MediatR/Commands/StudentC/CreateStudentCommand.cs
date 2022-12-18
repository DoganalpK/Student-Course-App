using AutoMapper;
using MediatR;
using StudentCourseApp.Application.Interfaces.Repository;
using StudentCourseApp.Application.Wrappers;
using StudentCourseApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourseApp.Application.Features.MediatR.Commands.StudentC
{
    public class CreateStudentCommand : IRequest<ServiceResponse<Guid>>
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public class CreateStudentCommandHandler : IRequestHandler<CreateStudentCommand, ServiceResponse<Guid>>
        {
            private readonly IStudentRepository _studentRepository;
            private readonly IMapper _mapper;

            public CreateStudentCommandHandler(IStudentRepository studentRepository, IMapper mapper)
            {
                _studentRepository = studentRepository;
                _mapper = mapper;
            }

            public async Task<ServiceResponse<Guid>> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
            {
                var dto = _mapper.Map<Student>(request);
                await _studentRepository.AddAsync(dto);
                return new ServiceResponse<Guid>(dto.Id);
            }
        }
    }
}
