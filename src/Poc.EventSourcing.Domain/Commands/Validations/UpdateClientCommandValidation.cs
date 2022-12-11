using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poc.EventSourcing.Domain.Commands.Validations
{
    public class UpdateClientCommandValidation: ClientValidation<ClientCommand>
    {
        public UpdateClientCommandValidation()
        {
            ValidateName();
            ValidateClAccountId();
            ValidateId();
            ValidateAddress();
        }
    }
}
