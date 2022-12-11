using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetDevPack.Messaging;
using Poc.EventSourcing.Domain.Models;

namespace Poc.EventSourcing.Domain.Events
{
    public class ClientUpdatedEvent : Event
    {
        public ClientUpdatedEvent(Guid id, string name, string clAccountId, Address address)
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
