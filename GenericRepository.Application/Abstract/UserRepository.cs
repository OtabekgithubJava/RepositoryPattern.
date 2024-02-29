using GenericRepository.Domain.Entities.Models;
using GenericRepository.Infrastructure.BaseRepositories;
using GenericRepository.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace GenericRepository.Application.Abstract;

public class UserRepository : BaseRepository<User>, IUserRepository
{
    public UserRepository(GenericRepositoryDbContext dbContext, DbSet<User> dbSet) : base(dbContext, dbSet)
    {
    }
}