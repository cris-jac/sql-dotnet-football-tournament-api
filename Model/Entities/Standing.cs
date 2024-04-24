using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities
{
    public class Standing
    {
        public int Id { get; set; }
        //public int Position { get; set; }
        [ForeignKey(nameof(Tournament))]
        public int TournamentId { get; set; }
        public Tournament? Tournament { get; set; }
        //public List<Club> Club { get; set; }
        // Added classes by Cruis
        public int ClubId { get; set; }
        public Club? Club { get; set; }
        //public List<int> MatchIds { get; set; } = new List<int>();
        public List<Match> Matches { get; set; }
        public int Points { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Draws { get; set; }
        public int PlayedMatches { get; set; }      // Necessary?
        public int GoalsFor { get; set; }
        public int GoalsAgainst { get; set; }
    }
}
