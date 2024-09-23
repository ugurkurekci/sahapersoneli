using AutoMapper;
using Entity.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Services.Abstract;
using Services.Dto;

namespace Services.Concrete;

public class TaskStatusService : ITaskStatusService
{

    private readonly ProjectDbContext _context;
    private readonly IMapper _mapper;

    public TaskStatusService(ProjectDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<TaskStatusDto>> GetAll()
    {

        var taskStatuses = await _context.TaskStatus.ToListAsync();
        return _mapper.Map<List<TaskStatusDto>>(taskStatuses);

    }

}