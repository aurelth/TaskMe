using AutoMapper;
using TaskMe.API.Models;
using TaskMe.API.Models.DTOs;
using TaskMe.API.Repositories.Interfaces;
using TaskMe.API.Services.Interfaces;

namespace TaskMe.API.Services
{
    public class TaskService : ITaskService    
    {
        private readonly ITaskRepository _taskRepository;
        private readonly IMapper _mapper;

        public TaskService(ITaskRepository taskRepository, IMapper mapper)
        {
            _taskRepository = taskRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TaskItemDTO>> GetAllTasksAsync()
        {
            var tasks = await _taskRepository.GetAllTasksAsync();
            return _mapper.Map<IEnumerable<TaskItemDTO>>(tasks);
        }

        public async Task<TaskItemDTO> GetTaskByIdAsync(int id)
        {
            var task = await _taskRepository.GetTaskByIdAsync(id);
            return _mapper.Map<TaskItemDTO>(task);
        }

        public async Task AddTaskAsync(TaskItemDTO taskDto)
        {
            var task = _mapper.Map<TaskItem>(taskDto);
            await _taskRepository.AddTaskAsync(task);
        }

        public async Task UpdateTaskAsync(TaskItemDTO taskDto)
        {
            var task = _mapper.Map<TaskItem>(taskDto);
            await _taskRepository.UpdateTaskAsync(task);
        }

        public async Task DeleteTaskAsync(int id)
        {
            await _taskRepository.DeleteTaskAsync(id);
        }
    }
}
