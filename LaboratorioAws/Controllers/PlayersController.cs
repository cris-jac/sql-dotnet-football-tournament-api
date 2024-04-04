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

            await _context.Players.AddAsync(player);
            return NoContent();
        }
    }
}