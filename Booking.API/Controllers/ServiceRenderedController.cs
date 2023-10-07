using AutoMapper;
using Booking.API.Models;
using Booking.Servises.Contracts.ReadServicesContracts;
using Microsoft.AspNetCore.Mvc;

namespace Booking.API.Controllers
{
    /// <summary>
    /// CRUD контроллер по работе с оказанными услугами
    /// </summary>
    [ApiController]
    [Route("[Controller]")]
    public class ServiceRenderedController : ControllerBase
    {
        private readonly IServiceRenderedService servicerenderedService;
        private readonly IMapper mapper;
        public ServiceRenderedController(IServiceRenderedService servicerenderedService, IMapper mapper)
        {
            this.servicerenderedService = servicerenderedService;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var result = await servicerenderedService.GetAllAsync(cancellationToken);
            return Ok(result.Select(x => mapper.Map<ServiceRenderedResponse>(x)));
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetById(Guid id, CancellationToken cancellationToken)
        {
            var item = await servicerenderedService.GetByIdAsync(id, cancellationToken);

            if (item == null)
            {
                return NotFound("Оказанной услуги с таким ID нет!");
            }

            return Ok(mapper.Map<ServiceRenderedResponse>(item));
        }
    }
}
