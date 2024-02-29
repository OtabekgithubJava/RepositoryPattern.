using GenericRepository.Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace GenericRepository.Infrastructure.Persistence;

public class GenericRepositoryDbContext : DbContext
{
    public GenericRepositoryDbContext(DbContextOptions<GenericRepositoryDbContext> options)
        : base(options)
    {
        // Database.Migrate();
    }
    
    public virtual DbSet<GenericRepository.Domain.Entities.Models.User> Users { get; set; }
        
}