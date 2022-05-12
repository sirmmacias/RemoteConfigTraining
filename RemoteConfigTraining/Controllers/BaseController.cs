using MediatR;
using Microsoft.AspNetCore.Mvc;
using RemoteConfigTraining.Services;
using RemoteConfigTraining.Services.GetFeature;

namespace RemoteConfigTraining.Controllers;

[ApiController]
[Route("[controller]")]
public class BaseController : ControllerBase
{
    protected readonly IMediator _mediator;

    public BaseController(IMediator mediator) : base()
    {
        _mediator = mediator;
    }

}
