namespace Model.Entities
{
    public class Match
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Club1Id { get; set; }            // Reference
        public Club? Club1 { get; set; }
        public int Club2Id { get; set; }            // Reference
        public Club? Club2 { get; set; }
        public int TournamentId { get; set; }            // Reference
        public Tournament? Tournament { get; set; }
        public int StadiumId { get; set; }            // Reference
        public Stadium? Stadium { get; set; }
        public string Referee { get; set; } = string.Empty;
        public int ScoreClub1 { get; set; }
        public int ScoreClub2 { get; set; }
        public Club? Winner { get; set; }
        public int PublicAttendence { get; set; }
    }
}
