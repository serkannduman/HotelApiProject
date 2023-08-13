using AutoMapper;
using HotelProject.DtoLayer.Dtos.RoomDto;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.WebApi.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<RoomAddDto, Room>();
            CreateMap<Room, RoomAddDto>(); // DTO SINIFINDAKILER VE ENTITY SINIFINDAKILER BIRBIRLERIYLE ESLESMIS OLUYOR.
            
            CreateMap<UpdateRoomDto,Room>().ReverseMap();
        }
    }
}
