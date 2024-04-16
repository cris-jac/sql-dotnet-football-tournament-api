namespace Model.Entities
{
    public class Tournament
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Organizer { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Club> Participants { get; set; }
        public Club Winner { get; set; }
        public Standing Standing { get; set; }
    }
}
