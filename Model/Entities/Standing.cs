using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities
{
    public class Standing
    {
        public int Id { get; set; }
        public int Position { get; set; }
        [ForeignKey(nameof(Tournament))]
        public int IdTorunament { get; set; }
        public Tournament Tournament { get; set; }
        public List<Club> Club { get; set; }
    }
}
