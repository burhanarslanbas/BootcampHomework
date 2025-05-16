using AutoMapper;
using BootcampHomework.Business.Abstracts;
using BootcampHomework.Business.Dtos.Requests.Bootcamp;
using BootcampHomework.Business.Dtos.Responses.Bootcamp;
using BootcampHomework.Entities;
using BootcampHomework.Repositories.Abstracts;

namespace BootcampHomework.Business.Concretes
{
    public class BootcampManager : IBootcampService
    {
        private readonly IBootcampRepository _bootcampRepository;
        private readonly IMapper _mapper;

        public BootcampManager(IBootcampRepository bootcampRepository, IMapper mapper)
        {
            _bootcampRepository = bootcampRepository;
            _mapper = mapper;
        }

        public CreatedBootcampResponse Add(CreateBootcampRequest request)
        {
            Bootcamp bootcamp = _mapper.Map<Bootcamp>(request);
            Bootcamp createdBootcamp = _bootcampRepository.Add(bootcamp);
            CreatedBootcampResponse response = _mapper.Map<CreatedBootcampResponse>(createdBootcamp);
            return response;
        }

        public DeletedBootcampResponse Delete(DeleteBootcampRequest request)
        {
            Bootcamp bootcamp = _mapper.Map<Bootcamp>(request);
            Bootcamp deletedBootcamp = _bootcampRepository.Delete(bootcamp);
            DeletedBootcampResponse response = _mapper.Map<DeletedBootcampResponse>(deletedBootcamp);
            return response;
        }

        public GetBootcampResponse GetById(GetByIdBootcampRequest request)
        {
            Bootcamp bootcamp = _bootcampRepository.Get(b => b.Id == request.Id);
            GetBootcampResponse response = _mapper.Map<GetBootcampResponse>(bootcamp);
            return response;
        }

        public List<GetListBootcampResponse> GetList()
        {
            List<Bootcamp> bootcamps = _bootcampRepository.GetAll();
            List<GetListBootcampResponse> response = _mapper.Map<List<GetListBootcampResponse>>(bootcamps);
            return response;
        }

        public UpdatedBootcampResponse Update(UpdateBootcampRequest request)
        {
            Bootcamp bootcamp = _mapper.Map<Bootcamp>(request);
            Bootcamp updatedBootcamp = _bootcampRepository.Update(bootcamp);
            UpdatedBootcampResponse response = _mapper.Map<UpdatedBootcampResponse>(updatedBootcamp);
            return response;
        }
    }
}
