using AutoMapper;
using Booking.API.Models;
using Booking.Servises.Contracts.ReadServicesContracts;
using Microsoft.AspNetCore.Mvc;
namespace Booking.API.Controllers
{
    /// <summary>
    /// CRUD контроллер по работе с классами номеров
    /// </summary>
    [ApiController]
    [Route("[Controller]")]
    public class TypeRoomController : ControllerBase
    {
        private readonly ITypeRoomService typeroomService;
        private readonly IMapper mapper;
        public TypeRoomController(ITypeRoomService typeroomService, IMapper mapper)
        {
            this.typeroomService = typeroomService;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var result = await typeroomService.GetAllAsync(cancellationToken);
            return Ok(result.Select(x => mapper.Map<TypeRoomResponse>(x)));
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetById(Guid id, CancellationToken cancellationToken)
        {
            var item = await typeroomService.GetByIdAsync(id, cancellationToken);

            if (item == null)
            {
                return NotFound("Класса номера с таким ID нет!");
            }

            return Ok(mapper.Map<TypeRoomResponse>(item));
        }
    }
}
