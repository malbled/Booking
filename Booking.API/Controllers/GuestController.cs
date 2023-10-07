using AutoMapper;
using Booking.API.Models;
using Booking.Servises.Contracts.ReadServicesContracts;
using Microsoft.AspNetCore.Mvc;

namespace Booking.API.Controllers
{
    /// <summary>
    /// CRUD контроллер по работе с постояльцами
    /// </summary>
    [ApiController]
    [Route("[Controller]")]
    public class GuestController : ControllerBase
    {
        private readonly IGuestService guestService;
        private readonly IMapper mapper;
        public GuestController(IGuestService guestService, IMapper mapper)
        {
            this.guestService = guestService;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var result = await guestService.GetAllAsync(cancellationToken);
            return Ok(result.Select(x => mapper.Map<GuestResponse>(x)));
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetById(Guid id, CancellationToken cancellationToken)
        {
            var item = await guestService.GetByIdAsync(id, cancellationToken);

            if (item == null)
            {
                return NotFound("Гостя с таким ID нет!");
            }

            return Ok(mapper.Map<GuestResponse>(item));
        }
    }
}
