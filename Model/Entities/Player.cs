using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Model.Entities
{
    public class Player : Person
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Position { get; set; } = string.Empty;
        public bool Starter { get; set; }
        [ForeignKey(nameof(Club))]
        public int ClubId { get; set; }
        [JsonIgnore]
        public virtual Club Club { get; set; }
    }
}
