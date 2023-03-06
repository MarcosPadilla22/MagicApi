using BusinessLogic.IService;
using Microsoft.AspNetCore.Mvc;

namespace ApiMagic.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class GrimoireController : ControllerBase
    {
        private readonly IGrimoireService _grimoireService;
        public GrimoireController(IGrimoireService grimoireService) { _grimoireService = grimoireService; }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var results = await _grimoireService.GetAll();
            return Ok(results);
        }

        [HttpGet]
        public async Task<IActionResult> GetRelationGrimorieAndUser()
        {
            var results = await _grimoireService.GetAllGrimoiresAndStudents();
            return Ok(results);
        }
    }
}
