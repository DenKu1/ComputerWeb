using System;

namespace ComputerNet.BLL.DTO
{
    public class DeviceDTO
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public DateTime Manufactured { get; set; }
        public long LogicAddress { get; set; }
        public long Mask { get; set; }
        public string HardwareAddress { get; set; }
    }
}
