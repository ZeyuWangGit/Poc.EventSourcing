using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using NetDevPack.Data;
using NetDevPack.Mediator;
using NetDevPack.Messaging;
using Poc.EventSourcing.Domain.Models;
using Poc.EventSourcing.Infra.Data.Mapping;

namespace Poc.EventSourcing.Infra.Data.Context
{
    public sealed class EFDbContext : DbContext, IUnitOfWork
    {
        private readonly IMediatorHandler _mediatorHandler;
        public EFDbContext(DbContextOptions<EFDbContext> options, IMediatorHandler mediatorHandler) : base(options)
        {
            _mediatorHandler = mediatorHandler;
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            ChangeTracker.AutoDetectChangesEnabled = false;
        }
        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<ValidationResult>();
            modelBuilder.Ignore<Event>();

            modelBuilder.ApplyConfiguration(new ClientMapper());
            base.OnModelCreating(modelBuilder);
        }

        public Task<bool> Commit()
        {
                throw new NotImplementedException();
        }
    }
}
