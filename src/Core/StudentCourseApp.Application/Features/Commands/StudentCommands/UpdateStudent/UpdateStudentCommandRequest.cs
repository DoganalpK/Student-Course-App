using MediatR;
using StudentCourseApp.Application.Wrappers;

namespace StudentCourseApp.Application.Features.Commands.StudentCommands.UpdateStudent
{
    /// <summary>
    /// MediatoR update student request
    /// </summary>
    public class UpdateStudentCommandRequest : IRequest<IResponse>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
