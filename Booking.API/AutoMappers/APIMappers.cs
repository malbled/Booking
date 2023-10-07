using AutoMapper;
using Booking.API.Models;
using Booking.Servises.Contracts.Models;

namespace Booking.API.AutoMappers
{
    public class APIMappers : Profile
    {
        public APIMappers()
        {
            CreateMap<ServiceModel, ServiceResponse>(MemberList.Destination);
            CreateMap<TypeRoomModel, TypeRoomResponse>(MemberList.Destination);
            CreateMap<GuestModel, GuestResponse>(MemberList.Destination);

            CreateMap<BookingRoomModel, BookingRoomResponse>(MemberList.Destination).
                ForMember(x => x.GuestFIO, opt => opt.MapFrom(src => src.GuestId == null ? null : src.GuestId.FIO)).
                ForMember(x => x.GuestPhone, opt => opt.MapFrom(src => src.GuestId == null ? null : src.GuestId.Telephone)).
                ForMember(x => x.RoomIdentifier, opt => opt.MapFrom(src => src.RoomId == null ? null : src.RoomId.Identifier));
            CreateMap<ServiceRenderedModel, ServiceRenderedResponse>(MemberList.Destination).
                ForMember(x => x.GuestFIO, opt => opt.MapFrom(src => src.GuestId == null ? null : src.GuestId.FIO)).
                ForMember(x => x.ServiceName, opt => opt.MapFrom(src => src.ServiceId == null ? null : src.ServiceId.Name));
            CreateMap<RoomModel, RoomResponse>(MemberList.Destination).
                ForMember(x => x.TypeRoom, opt => opt.MapFrom(src => src.TypeRoomId == null ? null : src.TypeRoomId.Name));
        }
    }
}
