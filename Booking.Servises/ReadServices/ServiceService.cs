using AutoMapper;
using Booking.Repositories.Contracts.ReadInterfaces;
using Booking.Servises.Contracts.Models;
using Booking.Servises.Contracts.ReadServicesContracts;

namespace Booking.Servises.ReadServices
{
    public class ServiceService : IServiceService
    {
        private readonly IServiceReadRepository serviceReadRepositiry;
        private readonly IMapper mapper;

        public ServiceService(IServiceReadRepository serviceReadRepositiry, IMapper mapper)
        {
            this.serviceReadRepositiry = serviceReadRepositiry;
            this.mapper = mapper;
        }

        async Task<IEnumerable<ServiceModel>> IServiceService.GetAllAsync(CancellationToken cancellationToken)
        {
            var result = await serviceReadRepositiry.GetAllAsync(cancellationToken);

            return result.Select(x => mapper.Map<ServiceModel>(x));
        }

        async Task<ServiceModel?> IServiceService.GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var item = await serviceReadRepositiry.GetByIdAsync(id, cancellationToken);

            if (item == null)
            {
                return null;
            }

            return mapper.Map<ServiceModel>(item);
        }
    }
}
