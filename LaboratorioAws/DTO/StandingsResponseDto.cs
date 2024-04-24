using Model.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace LaboratorioAws.DTO
{
    public class StandingsResponseDto
    {
        public int StandingId { get; set; }
        public string ClubName { get; set; }
        public int Points { get; set; }
        public int PlayedMatches { get; set; }      // Necessary?
    }
}
