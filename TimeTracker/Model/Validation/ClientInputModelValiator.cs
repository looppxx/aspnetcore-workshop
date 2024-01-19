using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeTracker.Model.Validation
{
    public class ClientInputModelValidator : AbstractValidator<ClientInputModel>
    {
        public ClientInputModelValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .Length(1, 100);
        }
    }
}