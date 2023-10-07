using AutoMapper;
using Booking.Repositories.Contracts.ReadInterfaces;
using Booking.Servises.Contracts.Models;
using Booking.Servises.Contracts.ReadServicesContracts;

namespace Booking.Servises.ReadServices
{
    public class GuestService : IGuestService
    {
        private readonly IGuestReadRepository guestReadRepositiry;
        private readonly IMapper mapper;

        public GuestService(IGuestReadRepository guestReadRepositiry, IMapper mapper)
        {
            this.guestReadRepositiry = guestReadRepositiry;
            this.mapper = mapper;
        }

        async Task<IEnumerable<GuestModel>> IGuestService.GetAllAsync(CancellationToken cancellationToken)
        {
            var result = await guestReadRepositiry.GetAllAsync(cancellationToken);

            return result.Select(x => mapper.Map<GuestModel>(x));
        }

        async Task<GuestModel?> IGuestService.GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var item = await guestReadRepositiry.GetByIdAsync(id, cancellationToken);

            if (item == null)
            {
                return null;
            }

            return mapper.Map<GuestModel>(item);
        }
    }
}
