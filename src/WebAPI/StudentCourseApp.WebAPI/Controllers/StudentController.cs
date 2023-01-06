using MediatR;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using StudentCourseApp.Application.Features.Commands.StudentCommands.CreateStudent;
using StudentCourseApp.Application.Features.Commands.StudentCommands.DeleteStudent;
using StudentCourseApp.Application.Features.Commands.StudentCommands.UpdateStudent;
using StudentCourseApp.Application.Features.Queries.StudentQueries.GetStudentById;

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
            return Ok();
        }

        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetById(int id)
        //{
        //    return Ok(await _mediator.Send(new GetStudentByIdQueryRequest() { Id = id }));
        //}

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(GetStudentByIdQueryRequest request)
        {
            return Ok(await _mediator.Send(request));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateStudentCommandRequest request)
        {
            return Ok(await _mediator.Send(request));
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateStudentCommandRequest request)
        {
            return Ok(await _mediator.Send(request));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(DeleteStudentCommandRequest request)
        {
            return Ok(await _mediator.Send(request));
        }
    }
}
