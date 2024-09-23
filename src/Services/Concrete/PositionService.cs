using Entity.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Services.Abstract;
using Services.Dto;

namespace Services.Concrete;

public class PositionService : IPositionService
{

    private readonly ProjectDbContext _context;

    public PositionService(ProjectDbContext context)
    {
        _context = context;
    }

    public async Task<List<PositionDto>> GetAll()
    {

        return await _context.Position.Select(x => new PositionDto
        {
            Id = x.Id,
            Name = x.Name
        }).ToListAsync();

    }

}