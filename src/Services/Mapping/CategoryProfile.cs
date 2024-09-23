using AutoMapper;
using Entity.Model;
using Services.Dto;

namespace Services.Mapping;

public class CategoryProfile : Profile
{
    public CategoryProfile()
    {
        CreateMap<Category, CategoryDto>();
    }
}