using Entity.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Services.Abstract;
using Services.Dto;

namespace Services.Concrete;

public class TaskStatusService : ITaskStatusService
{

    private readonly ProjectDbContext _context;

    public TaskStatusService(ProjectDbContext context)
    {
        _context = context;
    }

    public async Task<List<TaskStatusDto>> GetAll()
    {

        return await _context.TaskStatus.Select(x => new TaskStatusDto
        {
            Id = x.Id,
            Description = x.Description
        }).ToListAsync();

    }

}