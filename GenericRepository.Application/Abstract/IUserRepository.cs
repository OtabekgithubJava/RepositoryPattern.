using GenericRepository.Domain.Entities.Models;
using GenericRepository.Infrastructure.BaseRepositories;

namespace GenericRepository.Application.Abstract;

public interface IUserRepository : IBaseRepository<User>
{
}