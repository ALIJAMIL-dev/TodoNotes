using FluentValidation;
using FluentValidation.Results;
using System;

namespace TodoNotes.Business.Utilities
{
    public static class ValidationTool
    {
        public static void Validate<T>(IValidator<T> validator, T entity)
        {
            var context = new ValidationContext<T>(entity);
            ValidationResult result = validator.Validate(context);

            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
