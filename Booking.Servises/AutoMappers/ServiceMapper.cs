using AutoMapper;
using Booking.Context.Contracts.Models;
using Booking.Servises.Contracts.Models;

namespace Booking.Servises.AutoMappers
{
    public class ServiceMapper : Profile
    {
        public ServiceMapper()
        {
            CreateMap<Guest, GuestModel>(MemberList.Destination);
            
            CreateMap<Service, ServiceModel>(MemberList.Destination);
            CreateMap<TypeRoom, TypeRoomModel>(MemberList.Destination);
        }
    }
}
