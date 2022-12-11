using Poc.EventSourcing.Domain.Commands.Validations;
using Poc.EventSourcing.Domain.Models;

namespace Poc.EventSourcing.Domain.Commands
{
    public class AddNewClientCommand : ClientCommand
    {
        public AddNewClientCommand(string name, string clAccountId, Address address)
        {
            Name = name;
            ClAccountId = clAccountId;
            Address = address;
        }

        public override bool IsValid()
        {
            ValidationResult = new AddNewClientCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
