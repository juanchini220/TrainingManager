using Microsoft.AspNetCore.Mvc;
using TrainingManager.Application.Services;

namespace TrainingManager.Api.Controllers;

[ApiController]
[Route("api/[controller]")]

public class TrainingsController : ControllerBase
{
    private readonly TrainingService _trainingService;

    public TrainingsController(TrainingService trainingService)
    {
        _trainingService = trainingService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var trainings = _trainingService.GetTrainings();

        return Ok(trainings);
    }
}