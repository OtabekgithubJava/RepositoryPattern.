namespace GenericRepository.Domain.Entities.DTOs;

public class RegisterLogin
{
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string Password { get; set; }
    public string ConfirmPassword { get; set; }
    public string Login { get; set; }
}