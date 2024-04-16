namespace Model.Entities
{
    public class Player : Person
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Position { get; set; } = string.Empty;
        public bool Starter { get; set; }
    }
}
