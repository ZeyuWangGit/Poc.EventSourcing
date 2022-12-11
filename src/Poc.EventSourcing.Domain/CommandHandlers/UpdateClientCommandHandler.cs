using FluentValidation.Results;
using MediatR;
using NetDevPack.Messaging;
using Poc.EventSourcing.Domain.Commands;
using Poc.EventSourcing.Domain.Events;
using Poc.EventSourcing.Domain.Interfaces;
using Poc.EventSourcing.Domain.Models;

namespace Poc.EventSourcing.Domain.CommandHandlers
{
    public class UpdateClientCommandHandler: CommandHandler, IRequestHandler<UpdateClientCommand, ValidationResult>
    {
        private readonly IClientRepository _clientRepository;
        public UpdateClientCommandHandler(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task<ValidationResult> Handle(UpdateClientCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid()) return request.ValidationResult;

            var client = new Client(request.Id, request.Name, request.ClAccountId, request.Address);
            var existingClient = await _clientRepository.GetByClAccountId(request.ClAccountId);

            if (existingClient != null && existingClient.Id != client.Id)
            {
                if (!existingClient.Equals(client))
                {
                    AddError("The ClAccountId has already been taken.");
                    return ValidationResult;
                }
            }

            client.AddDomainEvent(new ClientUpdatedEvent(client.Id, request.Name, request.ClAccountId, request.Address));

            _clientRepository.Update(client);

            return await Commit(_clientRepository.UnitOfWork);
        }
        public void Dispose()
        {
            _clientRepository.Dispose();
        }
    }
}
