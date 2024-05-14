using Model.Entities;

namespace LaboratorioAws.DTO
{
    public class MatchResponseDto
    {
        public int Id { get; init; }
        public string Club1 { get; set; } = string.Empty;
        public string Club2 { get; set; } = string.Empty;
        public int ScoreClub1 { get; set; }
        public int ScoreClub2 { get; set; }

        public MatchResponseDto(Match match)
        {
            Id = match.Id;
            Club1 = match.Club1.Name;
            Club2 = match.Club2.Name;
            ScoreClub1 = match.ScoreClub1;
            ScoreClub2 = match.ScoreClub2;
        }
    }
}
