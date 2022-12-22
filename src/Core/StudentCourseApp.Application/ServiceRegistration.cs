﻿using FluentValidation.Results;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using StudentCourseApp.Application.Interfaces.Repository;
using StudentCourseApp.Application.Wrappers;
using System.Reflection;

namespace StudentCourseApp.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            var assmb = Assembly.GetExecutingAssembly();
            //var assmb = AppDomain.CurrentDomain.GetAssemblies();
            services.AddAutoMapper(assmb);
            services.AddMediatR(assmb);
        }

        //public static List<CustomValidationError> ConvertToCustomValidationError(this ValidationResult validationResult)
        //{
        //    List<CustomValidationError> customErrors = new();
        //    foreach (var error in validationResult.Errors)
        //    {
        //        customErrors.Add(new CustomValidationError()
        //        {
        //            PropertyName = error.PropertyName,
        //            ErrorMessage = error.ErrorMessage,
        //        });
        //    }
        //    return customErrors;
        //}
    }
}
