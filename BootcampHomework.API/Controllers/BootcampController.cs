using BootcampHomework.Business.Abstracts;
using BootcampHomework.Business.Dtos.Requests.Bootcamp;
using BootcampHomework.Business.Dtos.Responses.Bootcamp;
using Microsoft.AspNetCore.Mvc;

namespace BootcampHomework.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BootcampController : ControllerBase
    {
        private readonly IBootcampService _bootcampService;

        public BootcampController(IBootcampService bootcampService)
        {
            _bootcampService = bootcampService;
        }

        [HttpPost("Add")]
        public IActionResult Add([FromBody] CreateBootcampRequest request)
        {
            CreatedBootcampResponse response = _bootcampService.Add(request);
            return Created(nameof(GetById), response);
        }

        [HttpDelete("Delete/{id}")]
        public IActionResult Delete([FromRoute] DeleteBootcampRequest request)
        {
            DeletedBootcampResponse response = _bootcampService.Delete(request);
            return Ok(response);
        }

        [HttpGet("GetById/{id}")]
        public IActionResult GetById([FromRoute] GetByIdBootcampRequest request)
        {
            GetBootcampResponse response = _bootcampService.GetById(request);
            return Ok(response);
        }

        [HttpGet("GetList")]
        public IActionResult GetList()
        {
            List<GetListBootcampResponse> response = _bootcampService.GetList();
            return Ok(response);
        }

        [HttpPut("Update")]
        public IActionResult Update([FromBody] UpdateBootcampRequest request)
        {
            UpdatedBootcampResponse response = _bootcampService.Update(request);
            return Ok(response);
        }
    }
} 