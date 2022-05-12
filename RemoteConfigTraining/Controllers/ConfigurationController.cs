using MediatR;
using Microsoft.AspNetCore.Mvc;
using RemoteConfigTraining.Services;
using RemoteConfigTraining.Services.GetFeature;
using RemoteConfigTraining.Services.PostFeature;
using System.Net;

namespace RemoteConfigTraining.Controllers;

[ApiController]
[Route("[controller]")]
public class ConfigurationController : BaseController
{
    private readonly ILogger<ConfigurationController> _logger;
    public ConfigurationController(IMediator mediator) : base(mediator)
    {
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<FeatureCommand>>> GetWarehouses([FromQuery] GetFeaturesQuery query)
    {
        return Ok(await _mediator.Send(query));
    }

    [HttpPost]
    [ProducesResponseType(typeof(int), (int)HttpStatusCode.Created)]
    //[ProducesErrorResponseType(typeof(BaseResponseDTO))]
    public async Task<IActionResult> Post([FromBody] FeatureCommand model)
    {
        var command = new PostFeaturesCommand(model);
        var response = await _mediator.Send(command);

        return Created($"Created {response}", model);
    }
}
