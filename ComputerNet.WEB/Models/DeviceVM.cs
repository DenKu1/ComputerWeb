using System;

namespace ComputerNet.WEB.Models
{
    public class DeviceVM
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public DateTime Manufactured { get; set; }
        public long? LogicAddress { get; set; }
        public long? Mask { get; set; }
        public string HardwareAddress { get; set; }
    }
}