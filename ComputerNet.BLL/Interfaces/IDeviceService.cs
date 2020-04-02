using ComputerNet.BLL.DTO;
using System;
using System.Collections.Generic;

namespace ComputerNet.BLL.Interfaces
{
    public interface IDeviceService
    {
        IEnumerable<DeviceDTO> SearchByLogicAddress(long adress);

        DeviceDTO SearchByHardwareAddress(string adress);

        IEnumerable<DeviceDTO> SearchByModel(string modelName);

        IEnumerable<DeviceDTO> SearchByManufactureDate(DateTime manufactured);

        IEnumerable<DeviceDTO> SearchByRoomNumber(int roomNumber);

        IEnumerable<DeviceDTO> SearchByBuildingName(string buildingName);
    }
}

