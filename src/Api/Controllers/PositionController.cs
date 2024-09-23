using Microsoft.AspNetCore.Mvc;
using Services.Abstract;

namespace Api.Controllers;

public class PositionController : BaseController
{

    private readonly IPositionService _positionService;

    public PositionController(IPositionService positionService)
    {
        _positionService = positionService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var positions = await _positionService.GetAll();
        return Ok(positions);
    }
}