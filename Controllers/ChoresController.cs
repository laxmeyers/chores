using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace chores.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChoresController : ControllerBase
    {
        private readonly ChoresService _choresService;

        public ChoresController(ChoresService choresService)
        {
            _choresService = choresService;
        }

        [HttpGet]
        public ActionResult<List<Chore>> GetAllChores()
        {
            try
            {
                List<Chore> chores = _choresService.GetAllChores();
                return Ok(chores);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{choreId}")]
        public ActionResult<Chore> GetChoreById(int choreId)
        {
            try
            {
                Chore chore = _choresService.GetChoreById(choreId);
                return chore;
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public ActionResult<Chore> CreateChore([FromBody] Chore choreData)
        {
            try
            {
                Chore chore = _choresService.CreateChore(choreData);
                return Ok(chore);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{choreId}")]
        public ActionResult<string> RemoveChore(int choreId)
        {
            try
            {
                string chore = _choresService.RemoveChore(choreId);
                return chore;
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{choreId}/finished")]
        public ActionResult<Chore> FinishedChore(int choreId)
        {
            try
            {
                Chore chore = _choresService.FinishedChore(choreId);
                return chore;
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }


    }
}