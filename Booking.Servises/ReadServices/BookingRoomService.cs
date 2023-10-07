using AutoMapper;
using Booking.Repositories.Contracts.ReadInterfaces;
using Booking.Servises.Contracts.Models;
using Booking.Servises.Contracts.ReadServicesContracts;

namespace Booking.Servises.ReadServices
{
    public class BookingRoomService : IBookingRoomService
    {
        private readonly IBookingRoomReadRepository bookingroomReadRepository;
        private readonly IGuestReadRepository guestReadRepository;
        private readonly IRoomReadRepository roomReadRepository;
        private readonly IMapper mapper;

        public BookingRoomService(IBookingRoomReadRepository bookingroomReadRepository, IGuestReadRepository guestReadRepository,
            IRoomReadRepository roomReadRepository,
            IMapper mapper)
        {
            this.bookingroomReadRepository = bookingroomReadRepository;
            this.guestReadRepository = guestReadRepository;
            this.roomReadRepository = roomReadRepository;
            this.mapper = mapper;
        }

        async Task<IEnumerable<BookingRoomModel>> IBookingRoomService.GetAllAsync(CancellationToken cancellationToken)
        {
            var bookingrooms = await bookingroomReadRepository.GetAllAsync(cancellationToken);
            var guests = await guestReadRepository.
                GetByIdsAsync(bookingrooms.Select(x => x.GuestId).Distinct(), cancellationToken);

            var rooms = await roomReadRepository.
                GetByIdsAsync(bookingrooms.Select(x => x.RoomId).Distinct(), cancellationToken);

            var result = new List<BookingRoomModel>();

            foreach (var bookingroom in bookingrooms)
            {
                var guest = guests.FirstOrDefault(x => x.Id == bookingroom.GuestId);
                var room = rooms.FirstOrDefault(x => x.Id == bookingroom.RoomId);

                result.Add(
                    new BookingRoomModel
                    {
                        Id = bookingroom.Id,
                        GuestId = guest == null ? null : mapper.Map<GuestModel>(guest),
                        RoomId = room == null ? null : mapper.Map<RoomModel>(room),
                        DateCheckIn = bookingroom.DateCheckIn,
                        DateCheckOut = bookingroom.DateCheckOut
                    }
                );
            }

            return result;
        }

        async Task<BookingRoomModel?> IBookingRoomService.GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var item = await bookingroomReadRepository.GetByIdAsync(id, cancellationToken);

            if (item == null)
            {
                return null;
            }

            var guest = await guestReadRepository.GetByIdAsync(item.GuestId, cancellationToken);
            var room = await roomReadRepository.GetByIdAsync(item.RoomId, cancellationToken);

            return new BookingRoomModel
            {
                Id = item.Id,
                GuestId = guest == null ? null : mapper.Map<GuestModel>(guest),
                RoomId = room == null ? null : mapper.Map<RoomModel>(room),
                DateCheckIn = item.DateCheckIn,
                DateCheckOut = item.DateCheckOut
            };
        }
    }
}
