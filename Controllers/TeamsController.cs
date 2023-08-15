using AutoMapper;
using inter.Data;
using inter.DTOs;
//using inter.Migrations;
using inter.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace inter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly leagueDBContext context;
        private readonly IMapper mapper;

        public TeamsController(leagueDBContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        // GET: api/<TeamsController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var res = await context.Teams.Include(T => T.Players)
                                             .Include(T=> T.Owner)
                                             .Include(T => T.ScoutsTeams)
                                                .ThenInclude(ST => ST.Scouts)
                                             .ToListAsync();
                return Ok(res);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // GET api/<TeamsController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetbyID(int id)
        {
            try
            {
                //var team = context.Teams.Where(team => team.TeamID == id);
                var team = context.Teams.FindAsync(id);
                return Ok(team);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // POST api/<TeamsController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TeamsDTO TeamDTO)
        {
            try
            {
                var team = mapper.Map<Teams>(TeamDTO);    
                context.Teams.Add(team);
                await context.SaveChangesAsync();
                return Ok(TeamDTO);
            }
            catch (Exception ex) 
            {
                return StatusCode(500, ex.Message); 
            }
        }

        // PUT api/<TeamsController>/5
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] TeamsDTO TeamDTO)
        {
            try
            {
                var updatedTeam = mapper.Map<Teams>(TeamDTO);
                context.Teams.Update(updatedTeam);
                await context.SaveChangesAsync();
                return Ok(TeamDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // DELETE api/<TeamsController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                int rows = await context.Teams.Where(t=> t.TeamID == id).ExecuteDeleteAsync();
                if (rows == 0)
                    return NotFound("Team Was Not Found");
                return Ok(id);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
