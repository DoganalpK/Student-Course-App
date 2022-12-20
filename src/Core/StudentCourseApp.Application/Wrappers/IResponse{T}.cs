namespace StudentCourseApp.Application.Wrappers
{
    public interface IResponse<T>
    {
        T Data { get; set; }
        List<CustomValidationError> ValidationErrors { get; set; }
    }
}
