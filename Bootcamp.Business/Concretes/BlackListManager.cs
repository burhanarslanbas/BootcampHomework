using AutoMapper;
using BootcampHomework.Business.Abstracts;

namespace BootcampHomework.Business.Concretes
{
    public class BlackListManager : IBlackListService
    {
        private readonly IBlackListService _blackListService;
        private readonly IMapper _mapper;
        public BlackListManager(IBlackListService blackListService, IMapper mapper)
        {
            _blackListService = blackListService;
            _mapper = mapper;
        }
    }
}
