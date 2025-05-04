using AutoMapper;
using BootcampHomework.Business.Abstracts;

namespace BootcampHomework.Business.Concretes
{
    public class BootcampManager : IBootcampService
    {
        private readonly IBootcampService _bootcampService;
        private readonly IMapper _mapper;
        public BootcampManager(IBootcampService bootcampService, IMapper mapper)
        {
            _bootcampService = bootcampService;
            _mapper = mapper;
        }
    }
}
