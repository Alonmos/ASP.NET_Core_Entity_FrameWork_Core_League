using AutoMapper;
using inter.Data;
using inter.DTOs;
using inter.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace inter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly leagueDBContext context;
        private readonly IMapper mapper;

        public PlayersController (leagueDBContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        // GET: api/<PlayersController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var players = await context.Players
                    .OrderByDescending(P => P.ID)
                    .Include(P => P.Agents)
                    .Include(P => P.Teams)
                    .ToListAsync();
                return Ok(players);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message); 
            }
        }

        // GET api/<PlayersController>/5
        [HttpGet("id/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var player = await context.Players.Where(P => P.ID == id)
                                                   .Include(P=>P.Teams)
                                                   .ToListAsync();
                return Ok(player);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // POST api/<PlayersController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PlayerDTO player)
        {
            try
            {
                var newPlayer = mapper.Map<Players>(player);
                context.Add(newPlayer);
                await context.SaveChangesAsync();
                return Ok(newPlayer);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // PUT api/<PlayersController>/5
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] PlayerDTO player)
        {
            try
            {
                var updatedPlayer = mapper.Map<Players>(player);
                context.Update(updatedPlayer);
                await context.SaveChangesAsync();
                return Ok(updatedPlayer);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // DELETE api/<PlayersController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var playerToDelete = await context.Players.FindAsync(id);
                context.Players.Remove(playerToDelete);
                await context.SaveChangesAsync();
                return Ok(playerToDelete);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
