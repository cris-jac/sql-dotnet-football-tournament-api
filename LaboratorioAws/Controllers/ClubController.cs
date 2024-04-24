using LaboratorioAws.DTO;
using Microsoft.AspNetCore.Mvc;
using Model.Entities;
using Repository.Repositories;

namespace LaboratorioAws.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ClubController : ControllerBase
    {
        //FALTA AGREGAR METODO MPOST Y PUT, AGREGAR CON DTOS
        private readonly UnitOfWork _unitOfWork;

        public ClubController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // new method! -> get clubs simplified
        [HttpGet]
        public async Task<ActionResult> GetClubs()
        {
            var clubs = await _unitOfWork.Clubs.GetAll();

            List<ClubResponseDto> clubList = new List<ClubResponseDto>();

            foreach (var club in clubs)
            {
                var c = new ClubResponseDto
                {
                    ClubId = club.Id,
                    ClubName = club.Name
                };

                clubList.Add(c);
            }

            return Ok(clubList);
        }


        // new method! -> get club basic info
        [HttpGet("{id}")]
        public async Task<ActionResult> GetClubInfo(int id)
        {
            var club = await _unitOfWork.Clubs.GetId(id);
            if (club == null) return NotFound();
            var clubResponse = new ClubInfoDto();

            var players = club.Players;
            var playersResponse = new List<PlayerResponseDto>();
            foreach (var player in players)
            {
                var p = new PlayerResponseDto
                {
                    Surname = player.Surname,
                    Position = player.Position,
                    Number = player.Number
                };
                playersResponse.Add(p);
            }

            clubResponse.Name = club.Name;
            clubResponse.Manager = club.Manager;
            clubResponse.Players = playersResponse;

            return Ok(clubResponse);
        }


        [HttpGet("{id}/players")]
        public async Task<ActionResult<IEnumerable<Player>>> GetPlayersByClubId(int id)
        {
            var players = await _unitOfWork.Players.GetPlayersByClub(id);

            return Ok(players);
        }

        // In PlayersController?
        // [HttpGet("{playerid}")]
        // public async Task<ActionResult<Player>> GetPlayer(int playerid)
        // {
        //     var player = await _unitOfWork.Players.GetId(playerid);
        //     if (player == null)
        //     {
        //         return NotFound();
        //     }
        //     return Ok(player);
        // }


        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var existingClub = await _unitOfWork.Clubs.GetId(id);
            if (existingClub == null)
            {
                return NotFound();
            }

            _unitOfWork.Clubs.Delete(existingClub);     // Name change: Remove -> Delete
            await _unitOfWork.SaveAsync();                  // Name change: SaveChangesAsync -> SaveAsync

            return NoContent();
        }

    }
}
