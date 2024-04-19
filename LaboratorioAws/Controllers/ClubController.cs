using Microsoft.AspNetCore.Mvc;
using Model.Entities;
using Repository.Repositories;

namespace LaboratorioAws.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ClubController : ControllerBase
    {
        //FALTA AGREGAR METODO MPOST Y PUT, AGREGAR CON DTOS
        private readonly UnitOfWork _unitOfWork;

        public ClubController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("All")]
        public async Task<ActionResult<IEnumerable<Club>>> GetPlayers()
        {
            var clubs = await _unitOfWork.Clubs.GetAll();
            return Ok(clubs);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Player>> GetPlayer(int id)
        {
            var player = await _unitOfWork.Players.GetId(id);
            if (player == null)
            {
                return NotFound();
            }
            return Ok(player);
        }


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
