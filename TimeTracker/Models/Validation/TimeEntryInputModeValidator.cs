using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeTracker.Domain;

namespace TimeTracker.Model.Validation
{
    public class TimeEntryInputModelValidator : AbstractValidator<TimeEntryInputModel>
    {
        public TimeEntryInputModelValidator()
        {
            RuleFor(x => x.UserId)
                .NotEmpty();

            RuleFor(x => x.ProjectId)
                .NotEmpty();

            RuleFor(x => x.EntryDate)
                .GreaterThan(new DateTime(2019, 1, 1))
                .LessThan(new DateTime(2100, 1, 1));

            RuleFor(x => x.Hours)
                .InclusiveBetween(1, 24);

            RuleFor(x => x.Description)
                .NotEmpty()
                .MaximumLength(10000);
        }
    }
}