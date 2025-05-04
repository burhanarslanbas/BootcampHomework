using AutoMapper;
using BootcampHomework.Business.Abstracts;

namespace BootcampHomework.Business.Concretes
{
    public class ApplicationManager : IApplicationService
    {
        private readonly IApplicationService _applicationService;
        private readonly IMapper _mapper;
        public ApplicationManager(IApplicationService applicationService, IMapper mapper)
        {
            _applicationService = applicationService;
            _mapper = mapper;
        }
    }
}
