using Repository;
//using LaboratorioAws.Data; // esto no iria mas porque es del context
using Repository.interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LaboratorioAws.DTO;
using LaboratorioAws.Entities; // esto no deberia ser Model.entities????

namespace LaboratorioAws.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlayersController : ControllerBase
    {
        //private readonly DataContext _unitOfWork; //reemplaze todos los _unitOfWork por los _unitOfWork; 
        private readonly IUnitOfWork _unitOfWork;

        //public PlayersController(DataContext context)
        //{
        //    _unitOfWork = context;
        //}

        public PlayersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Player>>> GetPlayers()
        {
            var players = await _unitOfWork.PlayerRepository.GetAll(); // cambie ToListAsync por .GetALL
            return Ok(players);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Player>> GetPlayer(int id)
        {
            var player = await _unitOfWork.PlayerRepository.FirstOrDefaultAsync(x => x.Id == id); //habria que armar metodo para get por id ebn repository
            if (player == null)
            {
                return NotFound();
            }
            return Ok(player);
        }

        [HttpPost]
        public async Task<ActionResult> AddPlayer(PlayerDto playerDto)
        {
            if (playerDto == null)
            {
                return BadRequest();
            }

            var dateStringArray = playerDto.DateOfBirthYyyyMmDd.Split("-");
            var dateArray = dateStringArray.Select(n => int.Parse(n)).ToArray();

            var player = new Player
            {
                Name = playerDto.Name,
                Surname = playerDto.Surname,
                Position = playerDto.Position,
                Number = playerDto.Number,
                DocumentType = playerDto.DocumentType,
                DocumentNumber = playerDto.DocumentNumber,
                Starter = playerDto.Starter,
                DateOfBirth = new DateTime(dateArray[0], dateArray[1], dateArray[2])
            };

            _unitOfWork.Players.Add(player); //cambiar Player por PlayerRepository
            await _unitOfWork.SaveChangesAsync();

            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, PlayerDto playerDto)
        {
            var existingPlayer = await _unitOfWork.Players.FirstOrDefaultAsync(x => x.Id == id); //cambiar players por PlayerRepository
            if (existingPlayer == null)
            {
                return NotFound();
            }

            var dateStringArray = playerDto.DateOfBirthYyyyMmDd.Split("-");
            var dateArray = dateStringArray.Select(n => int.Parse(n)).ToArray();

            existingPlayer.Name = playerDto.Name;
            existingPlayer.Surname = playerDto.Surname;
            existingPlayer.Position = playerDto.Position;
            existingPlayer.Number = playerDto.Number;
            existingPlayer.DocumentType = playerDto.DocumentType;
            existingPlayer.DocumentNumber = playerDto.DocumentNumber;
            existingPlayer.Starter = playerDto.Starter;
            existingPlayer.DateOfBirth = new DateTime(dateArray[0], dateArray[1], dateArray[2]);

            _unitOfWork.Update(existingPlayer);
            await _unitOfWork.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var existingPlayer = await _unitOfWork.Players.FirstOrDefaultAsync(x => x.Id == id);
            if (existingPlayer == null)
            {
                return NotFound();
            }

            _unitOfWork.Players.Remove(existingPlayer);
            await _unitOfWork.SaveChangesAsync();

            return NoContent();
        }
    }
}