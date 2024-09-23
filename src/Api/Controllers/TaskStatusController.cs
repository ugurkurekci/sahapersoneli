using Microsoft.AspNetCore.Mvc;
using Services.Abstract;

namespace Api.Controllers;
public class TaskStatusController : BaseController
{

    private readonly ITaskStatusService _taskStatusService;

    public TaskStatusController(ITaskStatusService taskStatusService)
    {
        _taskStatusService = taskStatusService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {

        var result = await _taskStatusService.GetAll();
        return Ok(result);

    }

}