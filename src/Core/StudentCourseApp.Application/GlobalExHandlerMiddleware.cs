//using Microsoft.AspNetCore.Http;
//using Microsoft.Extensions.Logging;

//namespace StudentCourseApp.Application
//{
//    public class GlobalExHandlerMiddleware
//    {
//        private readonly RequestDelegate _next;

//        public GlobalExHandlerMiddleware(RequestDelegate next)
//        {
//            _next = next;
//        }

//        public async Task Invoke(HttpContext httpContext)
//        {
//            try
//            {
//                await _next.Invoke(httpContext);
//            }
//            catch (Exception ex)
//            {
//                throw ex;
//            }
//        }
//    }
//}
