using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace Poc.EventSourcing.Domain.Commands.Validations
{
    public abstract class ClientValidation<T> : AbstractValidator<T> where T : ClientCommand
    {
        protected void ValidateName()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("Name can't be empty")
                .Length(2, 150).WithMessage("Name length should be between 2 and 150 characters");
        }

        protected void ValidateClAccountId()
        {
            RuleFor(c => c.ClAccountId)
                .NotEmpty().WithMessage("ClAccountId must be provided");
        }

        protected void ValidateId()
        {
            RuleFor(c => c.Id)
                .NotEqual(Guid.Empty);
        }

        protected void ValidateAddress()
        {
            RuleFor(c => c.Address)
                .NotNull().WithMessage("Address Can not be null");
            RuleFor(c => c.Address!.PhysicalAddress)
                .NotEmpty().WithMessage("Physical Address must be provided");

        }
    }
}
