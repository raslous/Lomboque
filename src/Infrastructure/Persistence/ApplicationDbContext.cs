using Microsoft.EntityFrameworkCore;
using Lomboque.Application.Common.Interfaces;
using Lomboque.Domain.Entities;

namespace Lomboque.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        { }

        public DbSet<Observasi> LarikObservasi => Set<Observasi>();

        public new void SaveChanges()
            => base.SaveChanges();

        public async Task SaveChangesAsync()
            => await this.SaveChangesAsync();

    }
}