using AutoMapper;
using BootcampHomework.Business.Abstracts;
using BootcampHomework.Business.Dtos.Requests.Application;
using BootcampHomework.Business.Dtos.Responses.Application;
using BootcampHomework.Entities;
using BootcampHomework.Repositories.Abstracts;

namespace BootcampHomework.Business.Concretes
{
    public class ApplicationManager : IApplicationService
    {
        private readonly IApplicationRepository _applicationRepository;
        private readonly IMapper _mapper;

        public ApplicationManager(IApplicationRepository applicationRepository, IMapper mapper)
        {
            _applicationRepository = applicationRepository;
            _mapper = mapper;
        }

        public CreatedApplicationResponse Add(CreateApplicationRequest request)
        {
            Application application = _mapper.Map<Application>(request);
            Application createdApplication = _applicationRepository.Add(application);
            CreatedApplicationResponse response = _mapper.Map<CreatedApplicationResponse>(createdApplication);
            return response;
        }

        public DeletedApplicationResponse Delete(DeleteApplicationRequest request)
        {
            Application application = _mapper.Map<Application>(request);
            Application deletedApplication = _applicationRepository.Delete(application);
            DeletedApplicationResponse response = _mapper.Map<DeletedApplicationResponse>(deletedApplication);
            return response;
        }

        public GetApplicationResponse GetById(GetByIdApplicationRequest request)
        {
            Application application = _applicationRepository.Get(a => a.Id == request.Id);
            GetApplicationResponse response = _mapper.Map<GetApplicationResponse>(application);
            return response;
        }

        public List<GetListApplicationResponse> GetList()
        {
            List<Application> applications = _applicationRepository.GetAll();
            List<GetListApplicationResponse> response = _mapper.Map<List<GetListApplicationResponse>>(applications);
            return response;
        }

        public UpdatedApplicationResponse Update(UpdateApplicationRequest request)
        {
            Application application = _mapper.Map<Application>(request);
            Application updatedApplication = _applicationRepository.Update(application);
            UpdatedApplicationResponse response = _mapper.Map<UpdatedApplicationResponse>(updatedApplication);
            return response;
        }
    }
}
