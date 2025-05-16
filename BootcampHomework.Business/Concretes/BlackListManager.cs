using AutoMapper;
using BootcampHomework.Business.Abstracts;
using BootcampHomework.Business.Dtos.Requests.BlackList;
using BootcampHomework.Business.Dtos.Responses.BlackList;
using BootcampHomework.Entities;
using BootcampHomework.Repositories.Abstracts;

namespace BootcampHomework.Business.Concretes
{
    public class BlackListManager : IBlackListService
    {
        private readonly IBlackListRepository _blackListRepository;
        private readonly IMapper _mapper;

        public BlackListManager(IMapper mapper, IBlackListRepository blackListRepository)
        {
            _mapper = mapper;
            _blackListRepository = blackListRepository;
        }

        public CreatedBlackListResponse Add(CreateBlackListRequest request)
        {
            BlackList blackList = _mapper.Map<BlackList>(request);
            BlackList createdBlackList = _blackListRepository.Add(blackList);
            CreatedBlackListResponse response = _mapper.Map<CreatedBlackListResponse>(createdBlackList);
            return response;
        }

        public DeletedBlackListResponse Delete(DeleteBlackListRequest request)
        {
            BlackList blackList = _mapper.Map<BlackList>(request);
            BlackList deletedBlackList = _blackListRepository.Delete(blackList);
            DeletedBlackListResponse response = _mapper.Map<DeletedBlackListResponse>(deletedBlackList);
            return response;
        }

        public GetBlackListResponse GetById(GetByIdBlackListRequest request)
        {
            BlackList blackList = _blackListRepository.Get(b => b.Id == request.Id);
            GetBlackListResponse response = _mapper.Map<GetBlackListResponse>(blackList);
            return response;
        }

        public List<GetListBlackListResponse> GetList()
        {
            List<BlackList> blackLists = _blackListRepository.GetAll();
            List<GetListBlackListResponse> response = _mapper.Map<List<GetListBlackListResponse>>(blackLists);
            return response;
        }

        public UpdatedBlackListResponse Update(UpdateBlackListRequest request)
        {
            BlackList blackList = _mapper.Map<BlackList>(request);
            BlackList updatedBlackList = _blackListRepository.Update(blackList);
            UpdatedBlackListResponse response = _mapper.Map<UpdatedBlackListResponse>(updatedBlackList);
            return response;
        }
    }
}
