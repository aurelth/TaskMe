using TaskMe.API.Models.DTOs;

namespace TaskMe.API.Services.Interfaces
{
    public interface ITaskService
    {
        Task<IEnumerable<TaskItemDTO>> GetAllTasksAsync();
        Task<TaskItemDTO> GetTaskByIdAsync(int id);
        Task AddTaskAsync(TaskItemDTO taskDto);
        Task UpdateTaskAsync(TaskItemDTO taskDto);
        Task DeleteTaskAsync(int id);
    }
}
