using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetDevPack.Domain;

namespace Poc.EventSourcing.Domain.Models
{
    public class Client : Entity, IAggregateRoot
    {
        public Client(Guid id, string? name, string? clAccountId, Address? address)
        {
            Id = id;
            Name = name;
            ClAccountId = clAccountId;
            Address = address;
        }

        protected Client() {}
        public string Name { get; }
        public string ClAccountId { get; }
        public Address Address { get; }
    }
}
