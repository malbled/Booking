using AutoMapper;
using Booking.Repositories.Contracts.ReadInterfaces;
using Booking.Servises.Contracts.Models;
using Booking.Servises.Contracts.ReadServicesContracts;

namespace Booking.Servises.ReadServices
{
    public class TypeRoomService : ITypeRoomService
    {
        private readonly ITypeRoomReadRepository typeroomReadRepositiry;
        private readonly IMapper mapper;

        public TypeRoomService(ITypeRoomReadRepository typeroomReadRepositiry, IMapper mapper)
        {
            this.typeroomReadRepositiry = typeroomReadRepositiry;
            this.mapper = mapper;
        }

        async Task<IEnumerable<TypeRoomModel>> ITypeRoomService.GetAllAsync(CancellationToken cancellationToken)
        {
            var result = await typeroomReadRepositiry.GetAllAsync(cancellationToken);

            return result.Select(x => mapper.Map<TypeRoomModel>(x));
        }

        async Task<TypeRoomModel?> ITypeRoomService.GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var item = await typeroomReadRepositiry.GetByIdAsync(id, cancellationToken);

            if (item == null)
            {
                return null;
            }

            return mapper.Map<TypeRoomModel>(item);
        }
    }
}
