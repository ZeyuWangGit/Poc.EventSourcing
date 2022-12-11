using Poc.EventSourcing.Domain.Commands.Validations;
using Poc.EventSourcing.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poc.EventSourcing.Domain.Commands
{
    public class UpdateClientCommand: ClientCommand
    {
        public UpdateClientCommand(string name, string clAccountId, Address address)
        {
            Name = name;
            ClAccountId = clAccountId;
            Address = address;
        }
        public override bool IsValid()
        {
            ValidationResult = new UpdateClientCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
