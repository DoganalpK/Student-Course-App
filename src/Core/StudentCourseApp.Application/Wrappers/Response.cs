using StudentCourseApp.Application.Wrappers.Enums;
using System.Reflection;

namespace StudentCourseApp.Application.Wrappers
{
    public class Response : IResponse
    {
        public Response(ResponseType responseType)
        {
            ResponseType = responseType;
        }

        public Response(ResponseType responseType, string message)
        {
            ResponseType = responseType;
            Message = message;
        }
        public string Message { get; set; }
        public ResponseType ResponseType { get; set; }
    }
}
