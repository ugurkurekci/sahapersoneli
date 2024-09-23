using Services.Dto;

namespace Services.Abstract;

public interface ITaskStatusService
{

    Task<List<TaskStatusDto>> GetAll();

}