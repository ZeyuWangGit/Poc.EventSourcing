using NetDevPack.Messaging;
using Poc.EventSourcing.Domain.Models;
using System.Xml.Linq;

namespace Poc.EventSourcing.Domain.Events
{
    public class ClientAddedEvent : Event
    {
        public ClientAddedEvent(Guid id, string name, string clAccountId, Address address)
        {
            Id = id;
            Name = name;
            ClAccountId = clAccountId;
            Address = address;
        }

        public Guid Id { get; protected set; }
        public string? Name { get; protected set; }
        public string? ClAccountId { get; protected set; }
        public Address? Address { get; protected set; }
    }
}
