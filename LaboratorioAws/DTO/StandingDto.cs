using Model.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace LaboratorioAws.DTO
{
    public class StandingDto
    {
        public string ClubName { get; set; } = string.Empty;
        public int Points { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Draws { get; set; }
        public int PlayedMatches { get; set; }      // Necessary?
    }
}
