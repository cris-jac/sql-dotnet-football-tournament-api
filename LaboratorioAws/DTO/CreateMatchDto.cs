using Model.Entities;

namespace LaboratorioAws.DTO
{
    public class CreateMatchDto
    {
        public int TournamentId { get; set; }
        public DateTime Date { get; set; }
        public int Club1Id { get; set; }
        public int Club2Id { get; set; }
        public int StadiumId { get; set; }
        public string Referee { get; set; } = string.Empty;
        public int PublicAttendence { get; set; }
    }
}
