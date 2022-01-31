using Microsoft.EntityFrameworkCore;
using Lomboque.Domain.Entities;

namespace Lomboque.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Observasi> LarikObservasi { get; }
        
        void SaveChanges();
        Task SaveChangesAsync();
    }
}