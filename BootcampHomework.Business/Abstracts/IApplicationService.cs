using BootcampHomework.Business.Dtos.Requests.Application;
using BootcampHomework.Business.Dtos.Responses.Application;

namespace BootcampHomework.Business.Abstracts;

public interface IApplicationService
{
    CreatedApplicationResponse Add(CreateApplicationRequest request);
    UpdatedApplicationResponse Update(UpdateApplicationRequest request);
    DeletedApplicationResponse Delete(DeleteApplicationRequest request);
    GetApplicationResponse GetById(GetByIdApplicationRequest request);
    List<GetListApplicationResponse> GetList();
}
