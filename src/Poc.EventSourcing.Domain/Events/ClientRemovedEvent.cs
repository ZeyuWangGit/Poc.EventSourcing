using NetDevPack.Messaging;

namespace Poc.EventSourcing.Domain.Events
{
    public class ClientRemovedEvent : Event
    {
        public ClientRemovedEvent(Guid id)
        {
            Id = id;
            AggregateId = id;

        }
        
        public Guid Id { get; set; }
    }
}
