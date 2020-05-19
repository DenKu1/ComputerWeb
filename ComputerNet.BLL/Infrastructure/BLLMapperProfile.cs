using AutoMapper;

namespace ComputerNet.BLL.Infrastructure
{
    public class BLLMapperProfile : Profile
    {
        public BLLMapperProfile()
        {
            CreateMap<DTO.UserRegisterDTO, DAL.Entities.User>();

            CreateMap<DTO.BuildingDTO, DAL.Entities.Building>();
            CreateMap<DAL.Entities.Building, DTO.BuildingDTO>();

            CreateMap<DTO.ComputerDTO, DAL.Entities.Computer>();
            CreateMap<DAL.Entities.Computer, DTO.ComputerDTO>();
            CreateMap<DAL.Entities.Computer, BLL.DTO.DeviceDTO>();

            CreateMap<DTO.RoomDTO, DAL.Entities.Room>();
            CreateMap<DAL.Entities.Room, DTO.RoomDTO>();

            CreateMap<DTO.RouterDTO, DAL.Entities.Router>();
            CreateMap<DAL.Entities.Router, BLL.DTO.RouterDTO>();
            CreateMap<DAL.Entities.Router, BLL.DTO.DeviceDTO>();

        }
    }
}