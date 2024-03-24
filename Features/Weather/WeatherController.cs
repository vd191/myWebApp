using Features.Weather;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace myWebApp.Features.Weather;

[ApiController]
[Route("api/[controller]")]
public class WeatherController : ControllerBase
{
    private readonly IMediator _mediator;

    public WeatherController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public async Task<string> Get()
    {
        return await _mediator.Send(new Get());
    }
}