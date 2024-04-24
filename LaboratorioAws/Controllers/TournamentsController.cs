using LaboratorioAws.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.Entities;
using Repository.Repositories;

namespace LaboratorioAws.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TournamentsController : ControllerBase
    {
        private readonly UnitOfWork _unitOfWork;

        public TournamentsController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult> GetTournaments()
        {
            var tournaments = await _unitOfWork.Tournaments.GetAll();
            return Ok(tournaments);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetStandingsByTournament(int id)
        {
            var standings = await _unitOfWork.Standings.GetStandingsByTournament(id);

            List<StandingsResponseDto> stdLits = new List<StandingsResponseDto>();

            foreach (var standing in standings)
            {
                var std = new StandingsResponseDto
                {
                    StandingId = standing.Id,
                    ClubName = standing.Club.Name,
                    PlayedMatches = standing.PlayedMatches,
                    Points = standing.Points
                };

                stdLits.Add(std);
            }

            var sortedStdList = stdLits.OrderByDescending(x => x.Points).ToList();

            return Ok(sortedStdList);
        }


        [HttpPost]
        public async Task<ActionResult> CreateTournament(TournamentDto tournamentDto)
        {
            Tournament newTournament = new Tournament()
            {
                Name = tournamentDto.Name,
                Organizer = tournamentDto.Organizer,
                StartDate = tournamentDto.StartDate,
                EndDate = tournamentDto.EndDate,
                Winner = null
            };

            await _unitOfWork.Tournaments.Add(newTournament);
            await _unitOfWork.SaveAsync();
            return Ok(newTournament);
        }
    }
}
