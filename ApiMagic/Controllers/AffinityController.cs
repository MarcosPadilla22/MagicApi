using BusinessLogic.IService;
using Microsoft.AspNetCore.Mvc;

namespace ApiMagic.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class AffinityController : ControllerBase
    {
        private readonly IAffinityService _affinityService;
        public AffinityController(IAffinityService affinityService)
        {
            _affinityService = affinityService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var results = await _affinityService.GetAll();
            return Ok(results);
        }
    }
}
