using AutoMapper;

namespace ComputerNet.WEB.Infrastructure
{
    public class WEBMapperProfile : Profile
    {
        public WEBMapperProfile()
        {
            CreateMap<Models.UserRegisterVM, BLL.DTO.UserRegisterDTO>();
            CreateMap<Models.UserLoginVM, BLL.DTO.UserLoginDTO>();

            CreateMap<BLL.DTO.BuildingDTO, Models.BuildingVM>();
            CreateMap<Models.BuildingVM, BLL.DTO.BuildingDTO>();

            CreateMap<BLL.DTO.ComputerDTO, Models.ComputerVM>();
            CreateMap<Models.ComputerVM, BLL.DTO.ComputerDTO>();

            CreateMap<BLL.DTO.RoomDTO, Models.RoomVM>();
            CreateMap<Models.RoomVM, BLL.DTO.RoomDTO>();

            CreateMap<BLL.DTO.RouterDTO, Models.RouterVM>();
            CreateMap<Models.RouterVM, BLL.DTO.RouterDTO>();

            CreateMap<BLL.DTO.DeviceDTO, Models.DeviceVM>();
        }
    }
}