using AutoMapper;
using Booking.API.Models;
using Booking.Servises.Contracts.ReadServicesContracts;
using Microsoft.AspNetCore.Mvc;

namespace Booking.API.Controllers
{
    /// <summary>
    /// CRUD контроллер по работе с бронью
    /// </summary>
    [ApiController]
    [Route("[Controller]")]
    public class BookingRoomController : ControllerBase
    {
        private readonly IBookingRoomService bookingroomService;
        private readonly IMapper mapper;
        public BookingRoomController(IBookingRoomService bookingroomService, IMapper mapper)
        {
            this.bookingroomService = bookingroomService;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var result = await bookingroomService.GetAllAsync(cancellationToken);
            return Ok(result.Select(x => mapper.Map<BookingRoomResponse>(x)));
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetById(Guid id, CancellationToken cancellationToken)
        {
            var item = await bookingroomService.GetByIdAsync(id, cancellationToken);

            if (item == null)
            {
                return NotFound("Брони с таким ID нет!");
            }

            return Ok(mapper.Map<BookingRoomResponse>(item));
        }
    }
}
