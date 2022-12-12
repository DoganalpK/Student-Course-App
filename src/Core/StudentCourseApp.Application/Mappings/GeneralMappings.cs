using AutoMapper;
using StudentCourseApp.Application.Dtos;
using StudentCourseApp.Application.Features.MediatR.Commands;
using StudentCourseApp.Domain.Entities;

namespace StudentCourseApp.Application.Mappings
{
    public class GeneralMappings : Profile
    {
        public GeneralMappings()
        {
            CreateMap<Product, ProductViewDto>().ReverseMap();
            CreateMap<Product, CreateProductCommand>().ReverseMap();
        }
    }
}
