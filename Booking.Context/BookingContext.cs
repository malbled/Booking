using Booking.Context.Contracts;
using Booking.Context.Contracts.Models;

namespace Booking.Context
{
    public class BookingContext : IBookingContext
    {
        private readonly List<BookingRoom> bookingRooms;
        private readonly List<Guest> guests;
        private readonly List<Room> rooms;
        private readonly List<Service> services;
        private readonly List<ServiceRendered> servicesrendered;
        private readonly List<TypeRoom> typerooms;

        public BookingContext()
        {
            typerooms = new List<TypeRoom>()
            {
                new TypeRoom
                {
                    Id= Guid.NewGuid(),
                    Name = "Двухместный люкс",
                    Cost = 6500
                }
            };

            services = new List<Service>() 
            {
                new Service
                {
                    Id = Guid.NewGuid(),
                    Name = "ROOM SERVICE(завтрак)",
                    Description = "Доставка еды и напитков в номера",
                    Cost = 600
                }
            };

            rooms = new List<Room>() 
            {
                new Room
                {
                    Id = Guid.NewGuid(),
                    Identifier = "102B",
                    TypeRoomId = typerooms.First().Id,
                }
                
            };

            guests = new List<Guest>() 
            {
                new Guest
                {
                    Id = Guid.NewGuid(),
                    FIO = "Сазонова Анна Игоревна",
                    Passport = "4022 693568",
                    Telephone = "+79112355858"
                }
            };
            servicesrendered = new List<ServiceRendered>() 
            {
                new ServiceRendered 
                { 
                    Id = Guid.NewGuid(),
                    ServiceId = services.First().Id,
                    GuestId= guests.First().Id,
                    Quantity= 1,
                    DateRend= DateTime.Now
                }
            };
            bookingRooms = new List<BookingRoom>()
            {
                new BookingRoom
                {
                    Id = Guid.NewGuid(),
                    RoomId = rooms.First().Id,
                    GuestId = guests.First().Id,
                    DateCheckIn = DateTime.Now.AddDays(-1),
                    DateCheckOut = DateTime.Now.AddDays(5)
                }
            };
        }

        IEnumerable<BookingRoom> IBookingContext.BookingRooms => bookingRooms;

        IEnumerable<Guest> IBookingContext.Guests => guests;

        IEnumerable<Room> IBookingContext.Rooms => rooms;

        IEnumerable<Service> IBookingContext.Services => services;

        IEnumerable<ServiceRendered> IBookingContext.ServicesRendered => servicesrendered;

        IEnumerable<TypeRoom> IBookingContext.TypesRooms => typerooms;
    }
}
