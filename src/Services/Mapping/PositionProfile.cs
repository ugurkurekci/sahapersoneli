using AutoMapper;
using Entity.Model;
using Services.Dto;

namespace Services.Mapping;

public class PositionProfile : Profile
{

    public PositionProfile()
    {

        CreateMap<Position, PositionDto>();

    }

}