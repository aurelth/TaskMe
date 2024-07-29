using TaskMe.API.Models;

namespace TaskMe.API.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetUserByIdAsync(string id);
        Task<User> GetUserByEmailAsync(string email);
        Task AddUserAsync(User user);
    }
}
