using AutoMapper;
using Booking.API.Models;
using Booking.Servises.Contracts.ReadServicesContracts;
using Microsoft.AspNetCore.Mvc;

namespace Booking.API.Controllers
{
    /// <summary>
    /// CRUD контроллер по работе с номерами
    /// </summary>
    [ApiController]
    [Route("[Controller]")]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService roomService;
        private readonly IMapper mapper;
        public RoomController(IRoomService roomService, IMapper mapper)
        {
            this.roomService = roomService;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var result = await roomService.GetAllAsync(cancellationToken);
            return Ok(result.Select(x => mapper.Map<RoomResponse>(x)));
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetById(Guid id, CancellationToken cancellationToken)
        {
            var item = await roomService.GetByIdAsync(id, cancellationToken);

            if (item == null)
            {
                return NotFound("Номера с таким ID нет!");
            }

            return Ok(mapper.Map<RoomResponse>(item));
        }
    }
}
