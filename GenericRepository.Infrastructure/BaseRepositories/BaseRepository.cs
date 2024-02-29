using System.Linq.Expressions;
using GenericRepository.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace GenericRepository.Infrastructure.BaseRepositories;

public class BaseRepository<T> : IBaseRepository<T> where T : class
{

    private readonly GenericRepositoryDbContext _dbContext;
    private readonly DbSet<T> _dbSet;

    public BaseRepository(GenericRepositoryDbContext dbContext, DbSet<T> dbSet)
    {
        _dbContext = dbContext;
        _dbSet = dbSet;
    }

    public async Task<T> Create(T entity)
    {
        var result = await _dbSet.AddAsync(entity);

        await _dbContext.SaveChangesAsync();

        return result.Entity;
    }

    public async Task<T> GetByAny(Expression<Func<T, bool>> expression)
    {
        try
        {
            var result = await _dbSet.FirstOrDefaultAsync(expression);
            return result;
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    public async Task<IEnumerable<T>> GetAll()
    {
        return await _dbSet.ToListAsync();
    }

    public async Task<bool> Delete(Expression<Func<T, bool>> expression)
    {
        var result = await _dbSet.FirstOrDefaultAsync(expression);

        if (result == null)
        {
            return false;
        }

        _dbSet.Remove(result);
        await _dbContext.SaveChangesAsync();
        
        return true;
    }

    public async Task<T> Update(T entity)
    {
        var result = _dbSet.Update(entity);
        await _dbContext.SaveChangesAsync();

        return result.Entity;
    }
}