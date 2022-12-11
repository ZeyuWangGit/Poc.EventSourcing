using FluentValidation.Results;
using MediatR;
using NetDevPack.Messaging;
using Poc.EventSourcing.Domain.Commands;
using Poc.EventSourcing.Domain.Events;
using Poc.EventSourcing.Domain.Interfaces;
using Poc.EventSourcing.Domain.Models;

namespace Poc.EventSourcing.Domain.CommandHandlers
{
    public class AddNewClientCommandHandler : CommandHandler, IRequestHandler<AddNewClientCommand, ValidationResult>
    {
        private readonly IClientRepository _clientRepository;

        public AddNewClientCommandHandler(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task<ValidationResult> Handle(AddNewClientCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                return request.ValidationResult;
            }

            var client = new Client(Guid.NewGuid(), request.Name, request.ClAccountId, request.Address);

            var existingClient = await _clientRepository.GetByClAccountId(client.ClAccountId);
            if (existingClient != null)
            {
                AddError("Client Already exist");
                return ValidationResult;
            }

            client.AddDomainEvent(new ClientAddedEvent(client.Id, client.Name, client.ClAccountId, client.Address));
            _clientRepository.Add(client);
            return await Commit(_clientRepository.UnitOfWork);
        }
        public void Dispose()
        {
            _clientRepository.Dispose();
        }
    }
}
