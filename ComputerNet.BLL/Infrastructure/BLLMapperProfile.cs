using AutoMapper;

namespace ComputerNet.BLL.Infrastructure
{
    public class BLLMapperProfile : Profile
    {
        public BLLMapperProfile()
        {
            CreateMap<BLL.DTO.BuildingDTO, DAL.Entities.Building>();
            CreateMap<BLL.DTO.ComputerDTO, DAL.Entities.Computer>();
            CreateMap<BLL.DTO.RoomDTO, DAL.Entities.Room>();
            CreateMap<BLL.DTO.RouterDTO, DAL.Entities.Router>();

            CreateMap<DAL.Entities.Building, BLL.DTO.BuildingDTO>();
            CreateMap<DAL.Entities.Computer, BLL.DTO.ComputerDTO>();
            CreateMap<DAL.Entities.Room, BLL.DTO.RoomDTO>();
            CreateMap<DAL.Entities.Router, BLL.DTO.RouterDTO>();

            CreateMap<DAL.Entities.Router, BLL.DTO.DeviceDTO>();
            CreateMap<DAL.Entities.Computer, BLL.DTO.DeviceDTO>();
        }
    }
}