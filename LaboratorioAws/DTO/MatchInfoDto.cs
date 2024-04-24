using Model.Entities;

namespace LaboratorioAws.DTO
{
    public class MatchInfoDto
    {
        public int Id { get; set; }
        public string Tournament { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public string Stadium { get; set; } = string.Empty;
        public string Club1 { get; set; } = string.Empty;
        public string Club2 { get; set; } = string.Empty;
        public int ScoreClub1 { get; set; }
        public int ScoreClub2 { get; set; }
        public string Referee { get; set; } = string.Empty;
        public int PublicAttendence { get; set; }
    }
}
