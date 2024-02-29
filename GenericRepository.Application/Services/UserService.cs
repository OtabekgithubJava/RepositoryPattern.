using System.Linq.Expressions;
using GenericRepository.Domain.Entities.DTOs;
using GenericRepository.Domain.Entities.Models;

namespace GenericRepository.Application.Services;

public class UserService : IUserService
{
    public async Task<User> Create(User entity)
    {
        throw new NotImplementedException();
    }

    public async Task<User> GetByAny(Expression<Func<User, bool>> expression)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<User>> GetAll()
    {
        throw new NotImplementedException();
    }

    public async Task<bool> Delete(Expression<Func<User, bool>> expression)
    {
        throw new NotImplementedException();
    }

    public async Task<User> Update(int id, UserDTO userDto)
    {
        throw new NotImplementedException();
    }
}