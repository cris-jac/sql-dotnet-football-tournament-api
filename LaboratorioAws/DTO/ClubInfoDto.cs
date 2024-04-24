using Model.Entities;

namespace LaboratorioAws.DTO
{
    public class ClubInfoDto
    {
        public string Name { get; set; }
        public string Manager { get; set; }
        public List<PlayerResponseDto> Players { get; set; }
    }
}
