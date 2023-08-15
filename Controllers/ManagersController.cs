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
    public class ManagersController : ControllerBase
    {
        private readonly leagueDBContext context;
        private readonly IMapper mapper;

        public ManagersController(leagueDBContext context , IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        // GET: api/<ManagersController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var managers = context.Managers
                    .Include(M => M.TeamID)
                    .ToListAsync();
                return Ok(managers);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Server Error: " + ex.Message);
            }
        }

        // GET api/<ManagersController>/5
        [HttpGet("id/{id}")]
        public async Task<IActionResult> GetByID(int id)
        {
            try
            {
                var manager = context.Managers.Where(M => M.Id == id)
                                              .Include(M => M.TeamID);
                return Ok(manager);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Server Error: " + ex.Message);
            }
        }

        // POST api/<ManagersController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ManagersDTO ManagersDTO)
        {
            try
            {
                var manager = mapper.Map<Managers>(ManagersDTO);
                context.Managers.Add(manager);
                await context.SaveChangesAsync();
                return Ok(manager);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Server Error: " + ex.Message);
            }
        }

        // PUT api/<ManagersController>/5
        [HttpPut("id/{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] ManagersDTO ManagersDTO)
        {
            try
            {
                var manager = mapper.Map<Managers>(ManagersDTO);
                context.Managers.Update(manager);
                await context.SaveChangesAsync();
                return Ok(manager);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Server Error: " + ex.Message);
            }
        }

        // DELETE api/<ManagersController>/5
        [HttpDelete("id/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                //1
                //var manager = await context.Managers.FindAsync(id);
                //context.Managers.Remove(manager);
                //2
                int rows = await context.Managers.Where(M => M.Id == id).ExecuteDeleteAsync();
                return Ok(rows);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Server Error: " + ex.Message);
            }
        }
    }
}
