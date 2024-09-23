using AutoMapper;
using Entity.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Services.Abstract;
using Services.Dto;

namespace Services.Concrete;

public class CompanyService : ICompanyService
{

    private readonly ProjectDbContext _context;
    private readonly IMapper _mapper;

    public CompanyService(ProjectDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<CompanyDto>> GetAll()
    {

        var companies = await _context.Company.ToListAsync();
        return _mapper.Map<List<CompanyDto>>(companies);



    }

}