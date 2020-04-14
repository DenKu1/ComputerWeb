using AutoMapper;

namespace ComputerNet.API.Infrastructure
{
    public class APIMapperProfile : Profile
    {
        public APIMapperProfile()
        {
            CreateMap<BLL.DTO.BuildingDTO, Models.BuildingVM>();
            CreateMap<BLL.DTO.ComputerDTO, Models.ComputerVM>();
            CreateMap<BLL.DTO.RoomDTO, Models.RoomVM>();
            CreateMap<BLL.DTO.RouterDTO, Models.RouterVM>();

            CreateMap<Models.BuildingVM, BLL.DTO.BuildingDTO>();
            CreateMap<Models.ComputerVM, BLL.DTO.ComputerDTO>();
            CreateMap<Models.RoomVM, BLL.DTO.RoomDTO>();
            CreateMap<Models.RouterVM, BLL.DTO.RouterDTO>();
        }
    }
}