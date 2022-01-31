using Microsoft.EntityFrameworkCore;
using Lomboque.Domain.Entities;

namespace Lomboque.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Observasi> Observasi { get; }
        
        void SaveChanges();
        Task SaveChangesAsync();
    }
}