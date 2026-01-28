using FluentValidation;
using TodoNotes.Entities.Concrete;

namespace TodoNotes.Business.ValidationRules.FluentValidation
{
    public class NoteValidator : AbstractValidator<Note>
    {
        public NoteValidator()
        {
            RuleFor(n => n.Title)
                .NotEmpty().MinimumLength(3);

            RuleFor(n => n.Content)
                .NotEmpty().MaximumLength(2000);
        }
    }
}
