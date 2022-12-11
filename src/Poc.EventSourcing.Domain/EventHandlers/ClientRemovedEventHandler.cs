using MediatR;
using Poc.EventSourcing.Domain.Events;

namespace Poc.EventSourcing.Domain.EventHandlers
{
    public class ClientRemovedEventHandler : INotificationHandler<ClientRemovedEvent>
    {
        public Task Handle(ClientRemovedEvent notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
