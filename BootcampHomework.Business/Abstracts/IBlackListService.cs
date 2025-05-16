using BootcampHomework.Business.Dtos.Requests.BlackList;
using BootcampHomework.Business.Dtos.Responses.BlackList;

namespace BootcampHomework.Business.Abstracts;

public interface IBlackListService
{
    CreatedBlackListResponse Add(CreateBlackListRequest request);
    UpdatedBlackListResponse Update(UpdateBlackListRequest request);
    DeletedBlackListResponse Delete(DeleteBlackListRequest request);
    GetBlackListResponse GetById(GetByIdBlackListRequest request);
    List<GetListBlackListResponse> GetList();
}
