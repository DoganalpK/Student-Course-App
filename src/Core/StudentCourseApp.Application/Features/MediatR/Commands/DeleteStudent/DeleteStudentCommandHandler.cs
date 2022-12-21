using MediatR;
using StudentCourseApp.Application.Wrappers;
using StudentCourseApp.Application.Wrappers.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourseApp.Application.Features.MediatR.Commands.DeleteStudent
{
    public class DeleteStudentCommandHandler : IRequestHandler<DeleteStudentCommandRequest, IResponse>
    {
        public Task<IResponse> Handle(DeleteStudentCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
