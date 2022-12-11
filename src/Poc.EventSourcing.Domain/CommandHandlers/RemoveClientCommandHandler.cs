using FluentValidation.Results;
using MediatR;
using NetDevPack.Messaging;
using Poc.EventSourcing.Domain.Commands;
using Poc.EventSourcing.Domain.Events;
using Poc.EventSourcing.Domain.Interfaces;

namespace Poc.EventSourcing.Domain.CommandHandlers
{
    public class RemoveClientCommandHandler: CommandHandler, IRequestHandler<RemoveClientCommand, ValidationResult>
    {
        private readonly IClientRepository _clientRepository;
        public RemoveClientCommandHandler(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        public async Task<ValidationResult> Handle(RemoveClientCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid()) return request.ValidationResult;

            var client = await _clientRepository.GetById(request.Id);

            if (client is null)
            {
                AddError("The client doesn't exists.");
                return ValidationResult;
            }

            client.AddDomainEvent(new ClientRemovedEvent(request.Id));

            _clientRepository.Delete(client);

            return await Commit(_clientRepository.UnitOfWork);
        }
        public void Dispose()
        {
            _clientRepository.Dispose();
        }
    }
}
