using Poc.EventSourcing.Domain.Commands.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poc.EventSourcing.Domain.Commands
{
    public class RemoveClientCommand: ClientCommand
    {
        public RemoveClientCommand(Guid id)
        {
            Id = id;
            AggregateId = id;
        }

        public override bool IsValid()
        {
            ValidationResult = new RemoveClientCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
