using FluentValidation;
using FluentValidation.Results;
using System;
using System.Linq;

namespace TodoNotes.Business.Utilities
{
    public static class ValidationTool
    {
        public static void Validate<T>(IValidator<T> validator, T entity)
        {
            if (validator == null) throw new ArgumentNullException(nameof(validator));
            if (entity == null) throw new ArgumentNullException(nameof(entity));

            var context = new ValidationContext<T>(entity);
            ValidationResult result = validator.Validate(context);

            if (!result.IsValid)
            {
                var messages = result.Errors?.Select(e => e.ErrorMessage).Where(m => !string.IsNullOrWhiteSpace(m));
                var message = messages != null && messages.Any()
                    ? string.Join(Environment.NewLine, messages)
                    : "Validation failed.";

                throw new ValidationException(message);
            }
        }
    }
}
