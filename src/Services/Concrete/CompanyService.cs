using Entity.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Services.Abstract;
using Services.Dto;

namespace Services.Concrete;

public class CompanyService : ICompanyService
{

    private readonly ProjectDbContext _context;

    public CompanyService(ProjectDbContext context)
    {
        _context = context;
    }

    public async Task<List<CompanyDto>> GetAll()
    {

        return await _context.Company.Select(x => new CompanyDto
        {
            Id = x.Id,
            Name = x.Name,
            Address = x.Address,
            Phone = x.Phone,
            Email = x.Email,
            CategoryId = x.CategoryId,
            CityId = x.CityId,
            CreatedAt = x.CreatedAt.ToString(),
            IsActive = x.IsActive,
            UpdatedAt = x.UpdatedAt.ToString(),
            
        }).ToListAsync();

    }

}