using Services.Dto;

namespace Services.Abstract;

public interface IPositionService
{

    Task<List<PositionDto>> GetAll();

}