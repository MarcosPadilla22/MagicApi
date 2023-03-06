using BusinessLogic.DTO;
using BusinessLogic.IService;
using BusinessLogic.Validation;
using Microsoft.AspNetCore.Mvc;

namespace ApiMagic.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class StudentController : ControllerBase
    {
        private readonly ILogger<StudentController> _logger;
        private readonly IStudentService _service;

        public StudentController(
            IStudentService service,
            ILogger<StudentController> logger)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _service.Get(id);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _service.GetAll();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(StudentDTO dto)
        {
            StudentValidator validator = new();
            var validatorResult = validator.Validate(dto);
            if (!validatorResult.IsValid)
            {
                return StatusCode(StatusCodes.Status400BadRequest, validatorResult);
            }

            var result = await _service.Create(dto);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update(StudentDTO dto)
        {
            StudentValidator validator = new();
            var validatorResult = validator.Validate(dto);
            if (!validatorResult.IsValid)
            {
                return StatusCode(StatusCodes.Status400BadRequest, validatorResult);
            }

            await _service.Update(dto);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> ActiveOrInactive(int id)
        {
            await _service.ActiveOrInactive(id);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.Delete(id);
            return Ok();
        }

    }
}