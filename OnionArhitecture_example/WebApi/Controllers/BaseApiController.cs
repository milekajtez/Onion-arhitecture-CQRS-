using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public abstract class BaseApiController : ControllerBase
    {
        private IMediator? _mediator;
#pragma warning disable CS8603 // Possible null reference return.
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
#pragma warning restore CS8603 // Possible null reference return.
    }
}
