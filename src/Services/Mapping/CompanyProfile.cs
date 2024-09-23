using AutoMapper;
using Entity.Model;
using Services.Dto;

namespace Services.Mapping;

public class CompanyProfile : Profile
{
    public CompanyProfile()
    {

        CreateMap<Company, CompanyDto>()
            .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt.ToString()));

    }
}