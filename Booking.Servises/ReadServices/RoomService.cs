using AutoMapper;
using Booking.Repositories.Contracts.ReadInterfaces;
using Booking.Servises.Contracts.Models;
using Booking.Servises.Contracts.ReadServicesContracts;

namespace Booking.Servises.ReadServices
{
    public class RoomService : IRoomService
    {
        private readonly IRoomReadRepository roomRenderedReadRepository;
        private readonly ITypeRoomReadRepository typeroomReadRepository;
        private readonly IMapper mapper;

        public RoomService(IRoomReadRepository roomRenderedReadRepository, ITypeRoomReadRepository typeroomReadRepository,
            IMapper mapper)
        {
            this.roomRenderedReadRepository = roomRenderedReadRepository;
            this.typeroomReadRepository = typeroomReadRepository;
            this.mapper = mapper;
        }

        async Task<IEnumerable<RoomModel>> IRoomService.GetAllAsync(CancellationToken cancellationToken)
        {
            var rooms = await roomRenderedReadRepository.GetAllAsync(cancellationToken);
            var typesrooms = await typeroomReadRepository.
                GetByIdsAsync(rooms.Select(x => x.TypeRoomId).Distinct(), cancellationToken);

            var result = new List<RoomModel>();

            foreach (var room in rooms)
            {
                var typeroom = typesrooms.FirstOrDefault(x => x.Id == room.TypeRoomId);

                result.Add(
                    new RoomModel
                    {
                        Id = room.Id,
                        TypeRoomId = typeroom == null ? null : mapper.Map<TypeRoomModel>(typeroom),
                        Identifier = room.Identifier
                    }
                );
            }

            return result;
        }

        async Task<RoomModel?> IRoomService.GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var item = await roomRenderedReadRepository.GetByIdAsync(id, cancellationToken);

            if (item == null)
            {
                return null;
            }

            var typeroom = await typeroomReadRepository.GetByIdAsync(item.TypeRoomId, cancellationToken);

            return new RoomModel
            {
                Id = item.Id,
                TypeRoomId = typeroom == null ? null : mapper.Map<TypeRoomModel>(typeroom),
                Identifier = item.Identifier
            };
        }
    }
}
