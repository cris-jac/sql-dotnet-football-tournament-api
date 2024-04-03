namespace LaboratorioAws.Clases
{
    public class Match
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Club Club1 { get; set; }
        public Club Club2 { get; set; }
        public Tournament Tournament { get; set; }
        public Stadium Stadium { get; set; }
        public string Referee { get; set; }
        public int ScoreClub1 { get; set; }
        public int ScoreClub2 { get; set; }
        public Club Winner { get; set; }
        public int PublicAttendence { get; set; }
    }
}
