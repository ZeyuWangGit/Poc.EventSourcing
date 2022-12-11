using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetDevPack.Data;
using Poc.EventSourcing.Domain.Models;

namespace Poc.EventSourcing.Domain.Interfaces
{
    public interface IClientRepository : IRepository<Client>
    {
        Task<Client?> GetById(Guid id);
        Task<Client?> GetByClAccountId(string clAccountId);
        Task<IEnumerable<Client>> GetAll();
        void Add(Client client);
        void Update(Client client);
        void Delete(Client client);
    }
}
