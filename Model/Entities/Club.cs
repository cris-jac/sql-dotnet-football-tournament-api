namespace Model.Entities
{
    public class Club
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime FoundationDate { get; set; }
        public string Manager { get; set; }
        public List<Player> Players { get; set; }
        //public Standing Standing { get; set; } deberian volar?
    }
}
