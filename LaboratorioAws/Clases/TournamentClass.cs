namespace LaboratorioAws.Clases
{
    public class TournamentClass
    {
        public int id;
        public string name;
        public string organizer;
        public DateTime start_date;
        public DateTime end_date;
        public List<ClubClass> participants;
        public ClubClass winner;
        public List<StandingClass> standing;
    }
}
