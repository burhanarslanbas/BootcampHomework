using BootcampHomework.Business.Abstracts;
using BootcampHomework.Business.Dtos.Requests.Application;
using BootcampHomework.Business.Dtos.Responses.Application;
using Microsoft.AspNetCore.Mvc;

namespace BootcampHomework.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationController : ControllerBase
    {
        private readonly IApplicationService _applicationService;

        public ApplicationController(IApplicationService applicationService)
        {
            _applicationService = applicationService;
        }

        [HttpPost]
        public IActionResult Add([FromBody] CreateApplicationRequest request)
        {
            CreatedApplicationResponse response = _applicationService.Add(request);
            return Created(nameof(GetById), response);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] DeleteApplicationRequest request)
        {
            DeletedApplicationResponse response = _applicationService.Delete(request);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] GetByIdApplicationRequest request)
        {
            GetApplicationResponse response = _applicationService.GetById(request);
            return Ok(response);
        }

        [HttpGet]
        public IActionResult GetList()
        {
            List<GetListApplicationResponse> response = _applicationService.GetList();
            return Ok(response);
        }

        [HttpPut]
        public IActionResult Update([FromBody] UpdateApplicationRequest request)
        {
            UpdatedApplicationResponse response = _applicationService.Update(request);
            return Ok(response);
        }
    }
} 