using AutoMapper;
using StudentCourseApp.Application.Dtos;
using StudentCourseApp.Application.Features.MediatR.Commands.CreateStudent;
using StudentCourseApp.Application.Features.MediatR.Commands.UpdateStudent;
using StudentCourseApp.Domain.Entities;

namespace StudentCourseApp.Application.Mappings
{
    public class GeneralMappings : Profile
    {
        public GeneralMappings()
        {
            CreateMap<Student, StudentDto>().ReverseMap();
            CreateMap<Student, CreateStudentCommandRequest>().ReverseMap();
            CreateMap<Student, UpdateStudentCommandRequest>().ReverseMap();
        }
    }
}
