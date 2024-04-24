using LaboratorioAws.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Repositories;

namespace LaboratorioAws.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StandingsController : ControllerBase
    {
        private readonly UnitOfWork _unitOfWork;

        public StandingsController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult> GetStandings()
        {
            var standings = await _unitOfWork.Standings.GetAll();

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

        [HttpGet("{id}")]
        public async Task<ActionResult> GetStanding(int id)
        {
            var std = await _unitOfWork.Standings.GetId(id);

            if (std == null) return NotFound();

            StandingDto stdDto = new StandingDto
            {
                ClubName = std.Club.Name,
                Points = std.Points,
                Wins = std.Wins,
                Losses = std.Losses,
                Draws = std.Draws,
                PlayedMatches = std.PlayedMatches
            };

            return Ok(stdDto);
        }

        [HttpGet("{clubid}/standing")]
        public async Task<ActionResult> GetStandingByClub(int clubid)
        {
            var std = await _unitOfWork.Standings.GetStandingByClubId(clubid);

            if (std == null) return NotFound();

            StandingDto stdDto = new StandingDto
            {
                ClubName = std.Club.Name,
                Points = std.Points,
                Wins = std.Wins,
                Losses = std.Losses,
                Draws = std.Draws,
                PlayedMatches = std.PlayedMatches
            };

            return Ok(stdDto);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteStanding(int id)
        {

            var standing = await _unitOfWork.Standings.GetId(id);
            _unitOfWork.Standings.Delete(standing);
            await _unitOfWork.SaveAsync();
            return Ok("Deleted");
        }
    }
}
