using AutoMapper;
using Services.Dto;

namespace Services.Mapping;

public class TaskStatusProfile : Profile
{

    public TaskStatusProfile()
    {
        CreateMap<Entity.Model.TaskStatus, TaskStatusDto>();

    }

}