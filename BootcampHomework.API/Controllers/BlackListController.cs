using BootcampHomework.Business.Abstracts;
using BootcampHomework.Business.Dtos.Requests.BlackList;
using BootcampHomework.Business.Dtos.Responses.BlackList;
using Microsoft.AspNetCore.Mvc;

namespace BootcampHomework.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlackListController : ControllerBase
    {
        private readonly IBlackListService _blackListService;

        public BlackListController(IBlackListService blackListService)
        {
            _blackListService = blackListService;
        }

        [HttpPost]
        public IActionResult Add([FromBody] CreateBlackListRequest request)
        {
            CreatedBlackListResponse response = _blackListService.Add(request);
            return Created(nameof(GetById), response);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] DeleteBlackListRequest request)
        {
            DeletedBlackListResponse response = _blackListService.Delete(request);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] GetByIdBlackListRequest request)
        {
            GetBlackListResponse response = _blackListService.GetById(request);
            return Ok(response);
        }

        [HttpGet]
        public IActionResult GetList()
        {
            List<GetListBlackListResponse> response = _blackListService.GetList();
            return Ok(response);
        }

        [HttpPut]
        public IActionResult Update([FromBody] UpdateBlackListRequest request)
        {
            UpdatedBlackListResponse response = _blackListService.Update(request);
            return Ok(response);
        }
    }
} 