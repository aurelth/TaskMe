using AutoMapper;
using TaskMe.API.Models.DTOs;
using TaskMe.API.Models;

namespace TaskMe.API.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Task, TaskItemDTO>().ReverseMap();
            CreateMap<User, UserDTO>().ReverseMap();
        }
    }
}
