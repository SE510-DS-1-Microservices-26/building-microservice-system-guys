using Microsoft.AspNetCore.Mvc;

namespace CoreService.Api.Controllers;

[ApiController]
[Route("core-items")]
public class HabitsController : ControllerBase
{
    [HttpPost]
    public IActionResult Create()
    {
        return StatusCode(StatusCodes.Status501NotImplemented, new
        {
            message = "Create habit endpoint is not implemented yet."
        });
    }

    [HttpGet("{id:guid}")]
    public IActionResult GetById(Guid id)
    {
        return StatusCode(StatusCodes.Status501NotImplemented, new
        {
            message = "Get habit by id endpoint is not implemented yet."
        });
    }

    [HttpPatch("{id:guid}/status")]
    public IActionResult UpdateStatus(Guid id)
    {
        return StatusCode(StatusCodes.Status501NotImplemented, new
        {
            message = "Update habit status endpoint is not implemented yet."
        });
    }
}