using StudentCourseApp.Application.Wrappers.Enums;

namespace StudentCourseApp.Application.Wrappers
{
    public interface IResponse
    {
        string Message { get; set; }
        ResponseType ResponseType { get; set; }
    }
}
