using AutoMapper;
using MediatR;
using StudentCourseApp.Application.Dtos;
using StudentCourseApp.Application.Interfaces.UnitOfWork;
using StudentCourseApp.Application.Wrappers;
using StudentCourseApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourseApp.Application.Features.MediatR.Queries
{
    public class GetProductByIdQuery : IRequest<ServiceResponse<ProductViewDto>>
    {
        public Guid Id { get; set; }

        public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ServiceResponse<ProductViewDto>>
        {
            private readonly IUow _uow;
            private readonly IMapper _mapper;

            public GetProductByIdQueryHandler(IUow uow, IMapper mapper)
            {
                _uow = uow;
                _mapper = mapper;
            }

            public async Task<ServiceResponse<ProductViewDto>> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
            {
                var product = await _uow.GetRepository<Product>().GetByIdAsync(request.Id);
                var dto = _mapper.Map<ProductViewDto>(product);
                return new ServiceResponse<ProductViewDto>(dto);
            }
        }
    }
}
