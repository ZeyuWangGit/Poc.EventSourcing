using MediatR;
using Poc.EventSourcing.Domain.Events;

namespace Poc.EventSourcing.Domain.EventHandlers
{
    public class ClientUpdatedEventHandler : INotificationHandler<ClientUpdatedEvent>
    {
        public Task Handle(ClientUpdatedEvent notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
