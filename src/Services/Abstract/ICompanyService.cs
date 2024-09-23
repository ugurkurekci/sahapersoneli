using Services.Dto;

namespace Services.Abstract;

public interface ICompanyService
{

    Task<List<CompanyDto>> GetAll();

}