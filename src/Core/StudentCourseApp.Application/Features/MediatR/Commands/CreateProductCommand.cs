using AutoMapper;
using MediatR;
using StudentCourseApp.Application.Interfaces.Repository;
using StudentCourseApp.Application.Interfaces.UnitOfWork;
using StudentCourseApp.Application.Wrappers;
using StudentCourseApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourseApp.Application.Features.MediatR.Commands
{
    public class CreateProductCommand : IRequest<ServiceResponse<Guid>>
    {
        public String Name { get; set; }
        public decimal Value { get; set; }
        public int Quantity { get; set; }

        public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, ServiceResponse<Guid>>
        {
            private readonly IProductRepository _productRepository;
            private readonly IUow _uow;
            private readonly IMapper _mapper;

            public CreateProductCommandHandler(IProductRepository productRepository, IUow uow, IMapper mapper)
            {
                _productRepository = productRepository;
                _uow = uow;
                _mapper = mapper;
            }

            public async Task<ServiceResponse<Guid>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
            {
                var dto = _mapper.Map<Product>(request);
                await _uow.GetRepository<Product>().AddAsync(dto);
                await _uow.SaveChangesAsync();
                return new ServiceResponse<Guid>(dto.Id);
            }
        }
    }
}
