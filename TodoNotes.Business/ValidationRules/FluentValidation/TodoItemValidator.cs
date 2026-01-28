using FluentValidation;
using TodoNotes.Entities.Concrete;

public class TodoItemValidator : AbstractValidator<TodoItem>
{
    public TodoItemValidator()
    {
        RuleFor(x => x.Title)
            .NotEmpty()
            .MinimumLength(3);

        RuleFor(x => x.Description)
            .NotEmpty();
    }
}
