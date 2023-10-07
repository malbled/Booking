using Booking.Context.Contracts;
using Booking.Context.Contracts.Models;
using Booking.Repositories.Contracts.ReadInterfaces;

namespace Booking.Repositories.ReadRepositories
{
    /// <summary>
    /// Реализация <see cref="IBookingRoomReadRepository"/>
    /// </summary>
    public class BookingRoomReadRepository : IBookingRoomReadRepository
    {
        /// <summary>
        /// Контекст для связи с бд
        /// </summary>
        private IBookingContext context;

        public BookingRoomReadRepository(IBookingContext context)
        {
            this.context = context;
        }

        Task<List<BookingRoom>> IBookingRoomReadRepository.GetAllAsync(CancellationToken cancellationToken) =>
            Task.FromResult(context.BookingRooms.ToList());

        Task<BookingRoom?> IBookingRoomReadRepository.GetByIdAsync(Guid id, CancellationToken cancellationToken) =>
            Task.FromResult(context.BookingRooms.FirstOrDefault(x => x.Id == id));
    }
}
