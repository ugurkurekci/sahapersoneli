using AutoMapper;
using Entity.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Services.Abstract;
using Services.Dto;

namespace Services.Concrete;

public class PositionService : IPositionService
{

    private readonly ProjectDbContext _context;
    private readonly IMapper _mapper;

    public PositionService(ProjectDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<PositionDto>> GetAll()
    {

        var positions = await _context.Position.ToListAsync();
        return _mapper.Map<List<PositionDto>>(positions);

    }

}