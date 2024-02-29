using GenericRepository.Application.Abstract;
using GenericRepository.Domain.Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace GenericRepository;

[Route("api/[controller]")]
[ApiController]
public class Controller1 : ControllerBase
{
    private readonly IUserRepository _userRepository;

    public Controller1(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<User>>> GetAllUsers()
    {
        var result = await _userRepository.GetAll();

        return Ok(result);
    }
}