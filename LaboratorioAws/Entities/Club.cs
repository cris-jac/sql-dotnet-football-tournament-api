using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace LaboratorioAws.Clases
{
    public class Club
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime FoundationDate { get; set; }
        public string Manager { get; set; }
        public List<Player> Players { get; set; }
        public Standing Standing { get; set; }
    }
}
