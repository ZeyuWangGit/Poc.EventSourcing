using NetDevPack.Messaging;
using Poc.EventSourcing.Domain.Models;

namespace Poc.EventSourcing.Domain.Commands
{
    public abstract class ClientCommand : Command
    {
        public Guid Id { get; protected set; }
        public string Name { get; protected set; }
        public string ClAccountId { get; protected set; }
        public Address Address { get; protected set; }
    }
}
