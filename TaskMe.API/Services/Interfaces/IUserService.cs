using TaskMe.API.Models.DTOs;

namespace TaskMe.API.Services.Interfaces
{
    public interface IUserService
    {
        Task<UserDTO> GetUserByIdAsync(string id);
        Task<UserDTO> GetUserByEmailAsync(string email);
        Task AddUserAsync(UserDTO userDto);
    }
}
