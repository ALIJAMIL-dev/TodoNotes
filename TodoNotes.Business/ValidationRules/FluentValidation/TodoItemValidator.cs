using FluentValidation;
using TodoNotes.Entities.Concrete;

namespace TodoNotes.Business.ValidationRules.FluentValidation
{
    public class TodoItemValidator : AbstractValidator<TodoItem>
    {
        public TodoItemValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Title is required.")
                .MinimumLength(3).WithMessage("Title must be at least 3 characters long.");

            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("Description is required.");
        }
    }
}
