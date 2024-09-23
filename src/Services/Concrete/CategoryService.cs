using Entity.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Services.Abstract;
using Services.Dto;

namespace Services.Concrete;

public class CategoryService : ICategoryService
{

    private readonly ProjectDbContext _context;

    public CategoryService(ProjectDbContext context)
    {
        _context = context;
    }

    public async Task<List<CategoryDto>> GetAll()
    {

        return await _context.Category.Select(x => new CategoryDto
        {
            Id = x.Id,
            Name = x.Name
        }).ToListAsync();

    }

}