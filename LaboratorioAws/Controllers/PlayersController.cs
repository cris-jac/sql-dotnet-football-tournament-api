using LaboratorioAws.Entities;
using LaboratorioAws.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LaboratorioAws.DTO;

namespace LaboratorioAws.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlayersController : ControllerBase
    {
        private readonly DataContext _context;

        public PlayersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Player>>> GetPlayers()
        {
            var players = await _context.Players.ToListAsync();
            return Ok(players);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Player>> GetPlayer(int id)
        {
            var player = await _context.Players.FirstOrDefaultAsync(x => x.Id == id);
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

            _context.Players.Add(player);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, PlayerDto playerDto)
        {
            var existingPlayer = await _context.Players.FirstOrDefaultAsync(x => x.Id == id);
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

            _context.Update(existingPlayer);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var existingPlayer = await _context.Players.FirstOrDefaultAsync(x => x.Id == id);
            if (existingPlayer == null)
            {
                return NotFound();
            }

            _context.Players.Remove(existingPlayer);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}