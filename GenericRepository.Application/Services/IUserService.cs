using System.Linq.Expressions;
using GenericRepository.Domain.Entities.DTOs;
using GenericRepository.Domain.Entities.Models;

namespace GenericRepository.Application.Services;

public interface IUserService
{
    public Task<User> Create(User entity);
    public Task<User> GetByAny(Expression<Func<User, bool>> expression);
    public Task<IEnumerable<User>> GetAll();
    public Task<bool> Delete(Expression<Func<User, bool>> expression);
    public Task<User> Update(int id, UserDTO userDto);
}