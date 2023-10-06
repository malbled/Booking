using Booking.Context.Contracts.Models;

namespace Booking.Context.Contracts
{
    /// <summary>
    /// Контекст работы с сущностями
    /// </summary>
    public interface IBookingContext
    {
        /// <summary>
        /// Элементы брони номеров
        /// </summary>
        IEnumerable<BookingRoom> BookingRooms { get; }

        /// <summary>
        /// Постояльцы
        /// </summary>
        IEnumerable<Guest> Guests { get; }

        /// <summary>
        /// Номера
        /// </summary>
        IEnumerable<Room> Rooms { get; }

        /// <summary>
        /// Услуги
        /// </summary>
        IEnumerable<Service> Services { get; }

        /// <summary>
        /// Оказанные услуги
        /// </summary>
        IEnumerable<ServiceRendered> ServicesRendered { get; }

        /// <summary>
        /// Классы номеров
        /// </summary>
        IEnumerable<TypeRoom> TypesRooms { get; }
    }
}
