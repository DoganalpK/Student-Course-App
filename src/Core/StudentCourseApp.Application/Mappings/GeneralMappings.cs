using AutoMapper;
using StudentCourseApp.Application.Features.Commands.StudentCommands.CreateStudent;
using StudentCourseApp.Application.Features.Commands.StudentCommands.UpdateStudent;
using StudentCourseApp.Domain.Entities;

namespace StudentCourseApp.Application.Mappings
{
    public class GeneralMappings : Profile
    {
        public GeneralMappings()
        {
            CreateMap<Student, CreateStudentDto>().ReverseMap();
            CreateMap<Student, CreateStudentCommandRequest>().ReverseMap();
            CreateMap<Student, UpdateStudentCommandRequest>().ReverseMap();
        }
    }
}
