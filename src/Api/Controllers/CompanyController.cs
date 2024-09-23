using Microsoft.AspNetCore.Mvc;
using Services.Abstract;

namespace Api.Controllers;
public class CompanyController : BaseController
{

    private readonly ICompanyService _companyService;

    public CompanyController(ICompanyService companyService)
    {
        _companyService = companyService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _companyService.GetAll();
        return Ok(result);
    }

}