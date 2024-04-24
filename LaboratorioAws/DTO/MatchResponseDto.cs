namespace LaboratorioAws.DTO
{
    public class MatchResponseDto
    {
        public int Id { get; set; }
        public string Club1 { get; set; } = string.Empty;
        public string Club2 { get; set; } = string.Empty;
        public int ScoreClub1 { get; set; }
        public int ScoreClub2 { get; set; }
    }
}
