using AutoMapper;
using StudentCourseApp.Application.Dtos;
using StudentCourseApp.Application.Features.MediatR.Commands.CreateStudent;
using StudentCourseApp.Domain.Entities;

namespace StudentCourseApp.Application.Mappings
{
    public class GeneralMappings : Profile
    {
        public GeneralMappings()
        {
            CreateMap<CreateStudentCommandRequest, Student>().ReverseMap();
            CreateMap<CreateStudentCommandRequest, StudentDto>().ReverseMap();
        }
    }
}
