using MediatR;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using StudentCourseApp.Application.Features.MediatR.Commands.CreateStudent;
using StudentCourseApp.Application.Features.MediatR.Commands.UpdateStudent;
using StudentCourseApp.Application.Features.MediatR.Queries.GetAllStudents;
using StudentCourseApp.Application.Features.MediatR.Queries.GetStudentById;

namespace StudentCourseApp.WebAPI.Controllers
{
    [EnableCors]
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
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _mediator.Send(new GetAllStudentsQueryRequest()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _mediator.Send(new GetStudentByIdQueryRequest() { Id = id }));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody]CreateStudentCommandRequest request)
        {
            return Ok(await _mediator.Send(request));
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateStudentCommandRequest request)
        {
            return Ok(await _mediator.Send(request));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            return Ok(string.Empty);
        }
    }
}
