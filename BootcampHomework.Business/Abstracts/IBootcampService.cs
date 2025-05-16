using BootcampHomework.Business.Dtos.Requests.Bootcamp;
using BootcampHomework.Business.Dtos.Responses.Bootcamp;

namespace BootcampHomework.Business.Abstracts;
public interface IBootcampService
{
    CreatedBootcampResponse Add(CreateBootcampRequest request);
    UpdatedBootcampResponse Update(UpdateBootcampRequest request);
    DeletedBootcampResponse Delete(DeleteBootcampRequest request);
    GetBootcampResponse GetById(GetByIdBootcampRequest request);
    List<GetListBootcampResponse> GetList();
}
