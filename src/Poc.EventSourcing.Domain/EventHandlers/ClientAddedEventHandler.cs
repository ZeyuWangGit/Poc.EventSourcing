using MediatR;
using Poc.EventSourcing.Domain.Events;

namespace Poc.EventSourcing.Domain.EventHandlers
{
    public class ClientAddedEventHandler : INotificationHandler<ClientAddedEvent>
    {
        public Task Handle(ClientAddedEvent notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
