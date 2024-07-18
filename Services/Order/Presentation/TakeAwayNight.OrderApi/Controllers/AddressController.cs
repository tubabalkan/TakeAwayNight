using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TakeAwayNight.Application.Features.CQRS.Handlers.AddressHandlers;
using TakeAwayNight.Application.Features.CQRS.Results.AddressResults;

namespace TakeAwayNight.OrderApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly GetAddressQuerHandler _getAddressQuerHandler;

    }
}
