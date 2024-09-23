using Services.Dto;

namespace Services.Abstract;

public interface ICategoryService
{

    Task<List<CategoryDto>> GetAll();

}