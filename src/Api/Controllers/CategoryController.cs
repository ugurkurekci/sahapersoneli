using Microsoft.AspNetCore.Mvc;
using Services.Abstract;

namespace Api.Controllers;

public class CategoryController : BaseController
{


    private readonly ICategoryService _categoryService;

    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var category = await _categoryService.GetAll();
        return Ok(category);
    }
}