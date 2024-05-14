using LaboratorioAws.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.DTO;
using Model.Entities;
using Model.Services;
using Repository.Repositories;

namespace LaboratorioAws.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchesController : ControllerBase
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly StandingService _standingService;

        public MatchesController(
            UnitOfWork unitOfWork,
            StandingService standingService
        )
        {
            _unitOfWork = unitOfWork;
            _standingService = standingService;
        }

        [HttpGet("error-test")]
        public IActionResult GetError()
        {
            throw new Exception();
        }

        [HttpGet]
        public async Task<ActionResult> GetMatches()
        {
            var matches = await _unitOfWork.Matches.GetAll();

            List<MatchResponseDto> matchesResponse = new List<MatchResponseDto>();

            foreach (var match in matches)
            {
                //var m = new MatchResponseDto
                //{
                //    Id = match.Id,
                //    Club1 = match.Club1.Name,
                //    Club2 = match.Club2.Name,
                //    ScoreClub1 = match.ScoreClub1,
                //    ScoreClub2 = match.ScoreClub2
                //};

                var m = new MatchResponseDto(match);

                matchesResponse.Add(m);
            }

            return Ok(matchesResponse);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MatchInfoDto>> GetMatchInfo(int id)
        {
            var match = await _unitOfWork.Matches.GetId(id);

            if (match == null) return NotFound();

            MatchInfoDto matchDto = new MatchInfoDto
            {
                Id = match.Id,
                Tournament = match.Tournament.Name,
                Date = match.Date,
                Stadium = match.Stadium.Name,
                Club1 = match.Club1.Name,
                Club2 = match.Club2.Name,
                ScoreClub1 = match.ScoreClub1,
                ScoreClub2 = match.ScoreClub2,
                Referee = match.Referee,
                //Winner = match.Winner.Name,
                PublicAttendence = match.PublicAttendence
            };

            return Ok(matchDto);
        }

        [HttpPost]
        public async Task<ActionResult> CreateMatch(CreateMatchDto dto)
        {
            Match newMatch = new Match
            {
                TournamentId = dto.TournamentId,
                Date = dto.Date,
                Club1Id = dto.Club1Id,
                Club2Id = dto.Club2Id,
                StadiumId = dto.StadiumId,
                Referee = dto.Referee,
                PublicAttendence = dto.PublicAttendence         // Puede saberse con antelacion?
            };

            await _unitOfWork.Matches.Add(newMatch);
            await _unitOfWork.SaveAsync();

            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateMatchResults(int id, [FromBody] SetMatchResultsDto resultsDto)
        {
            // Check if match exists
            var existingMatch = await _unitOfWork.Matches.GetId(id);
            if (existingMatch == null) return NotFound();

            // Set match results
            existingMatch.ScoreClub1 = resultsDto.ScoreClub1;
            existingMatch.ScoreClub2 = resultsDto.ScoreClub2;

            // Save Match results
            _unitOfWork.Matches.Edit(existingMatch);
            await _unitOfWork.SaveAsync();

            // --- Refactored from here ---
            // Get teams standings for Club1
            var standingClub1 = await _standingService.InsertAndGetStandingByClubId(existingMatch.Club1Id, existingMatch.TournamentId);

            // Get teams standings for Club2
            var standingClub2 = await _standingService.InsertAndGetStandingByClubId(existingMatch.Club2Id, existingMatch.TournamentId);

            // Set Standing and matches
            await _standingService.SetResultInStandings(existingMatch, standingClub1, standingClub2, resultsDto);

            return NoContent();
        }


    }
}
