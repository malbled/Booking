using AutoMapper;
using Booking.Repositories.Contracts.ReadInterfaces;
using Booking.Servises.Contracts.Models;
using Booking.Servises.Contracts.ReadServicesContracts;

namespace Booking.Servises.ReadServices
{
    public class ServiceRenderedService : IServiceRenderedService
    {
        private readonly IServiceRenderedReadRepository serviceRenderedReadRepository;
        private readonly IGuestReadRepository guestReadRepository;
        private readonly IServiceReadRepository serviceReadRepository;
        private readonly IMapper mapper;

        public ServiceRenderedService(IServiceRenderedReadRepository serviceRenderedReadRepository, IGuestReadRepository guestReadRepository,
            IServiceReadRepository serviceReadRepository,
            IMapper mapper)
        {
            this.serviceRenderedReadRepository = serviceRenderedReadRepository;
            this.guestReadRepository = guestReadRepository;
            this.serviceReadRepository = serviceReadRepository;
            this.mapper = mapper;
        }

        async Task<IEnumerable<ServiceRenderedModel>> IServiceRenderedService.GetAllAsync(CancellationToken cancellationToken)
        {
            var servisesrendered = await serviceRenderedReadRepository.GetAllAsync(cancellationToken);
            var guests = await guestReadRepository.
                GetByIdsAsync(servisesrendered.Select(x => x.GuestId).Distinct(), cancellationToken);

            var services = await serviceReadRepository.
                GetByIdsAsync(servisesrendered.Select(x => x.ServiceId).Distinct(), cancellationToken);

            var result = new List<ServiceRenderedModel>();

            foreach (var servicerendered in servisesrendered)
            {
                var guest = guests.FirstOrDefault(x => x.Id == servicerendered.GuestId);
                var service = services.FirstOrDefault(x => x.Id == servicerendered.ServiceId);

                result.Add(
                    new ServiceRenderedModel
                    {
                        Id = servicerendered.Id,
                        GuestId = guest == null ? null : mapper.Map<GuestModel>(guest),
                        ServiceId = service == null ? null : mapper.Map<ServiceModel>(service),
                        Quantity = servicerendered.Quantity,
                        DateRend = servicerendered.DateRend
                    }
                );
            }

            return result;
        }

        async Task<ServiceRenderedModel?> IServiceRenderedService.GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var item = await serviceRenderedReadRepository.GetByIdAsync(id, cancellationToken);

            if (item == null)
            {
                return null;
            }

            var guest = await guestReadRepository.GetByIdAsync(item.GuestId, cancellationToken);
            var service = await serviceReadRepository.GetByIdAsync(item.ServiceId, cancellationToken);

            return new ServiceRenderedModel
            {
                Id = item.Id,
                GuestId = guest == null ? null : mapper.Map<GuestModel>(guest),
                ServiceId = service == null ? null : mapper.Map<ServiceModel>(service),
                Quantity = item.Quantity,
                DateRend = item.DateRend
            };
        }
    }
}
