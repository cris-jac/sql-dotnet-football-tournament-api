namespace Model.Entities
{
    public class Stadium
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int Capacity { get; set; }
        public Club Owner { get; set; }
    }
}
