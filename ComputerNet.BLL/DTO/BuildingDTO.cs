using ComputerNet.DAL.Interfaces;

namespace ComputerNet.BLL.DTO
{
    public class BuildingDTO : IRequireId
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
