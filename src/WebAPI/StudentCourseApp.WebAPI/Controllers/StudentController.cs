using MediatR;
using Microsoft.AspNetCore.Mvc;
using StudentCourseApp.Application.Features.MediatR.Commands.CreateStudent;

namespace StudentCourseApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StudentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(CreateStudentCommandRequest request)
        {
            return Ok(await _mediator.Send(request));
        }
    }
}
