using Microsoft.AspNetCore.Mvc;

namespace TrainingManager.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TrainingsController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var trainings = new[]
        {
            new { Id = 1, Name = "Push Day" },
            new { Id = 2, Name = "Pull Day" }
        };

        return Ok(trainings);
    }
}
