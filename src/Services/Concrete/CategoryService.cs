using AutoMapper;
using Entity.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Services.Abstract;
using Services.Dto;

namespace Services.Concrete;

public class CategoryService : ICategoryService
{

    private readonly ProjectDbContext _context;
    private readonly IMapper _mapper;

    public CategoryService(ProjectDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<CategoryDto>> GetAll()
    {
        var categories = await _context.Category.ToListAsync();
        return _mapper.Map<List<CategoryDto>>(categories);
    }

}