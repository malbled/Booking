using AutoMapper;
using Booking.API.Models;
using Booking.Servises.Contracts.ReadServicesContracts;
using Microsoft.AspNetCore.Mvc;

namespace Booking.API.Controllers
{
        /// <summary>
        /// CRUD контроллер по работе с услугами
        /// </summary>
        [ApiController]
        [Route("[Controller]")]
        public class ServiceController : ControllerBase
        {
            private readonly IServiceService serviceService;
            private readonly IMapper mapper;
            public ServiceController(IServiceService serviceService, IMapper mapper)
            {
                this.serviceService = serviceService;
                this.mapper = mapper;
            }

            [HttpGet]
            public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
            {
                var result = await serviceService.GetAllAsync(cancellationToken);
                return Ok(result.Select(x => mapper.Map<ServiceResponse>(x)));
            }

            [HttpGet("{id:guid}")]
            public async Task<IActionResult> GetById(Guid id, CancellationToken cancellationToken)
            {
                var item = await serviceService.GetByIdAsync(id, cancellationToken);

                if (item == null)
                {
                    return NotFound("Услуги с таким ID нет!");
                }

                return Ok(mapper.Map<ServiceResponse>(item));
            }
        }
    }

