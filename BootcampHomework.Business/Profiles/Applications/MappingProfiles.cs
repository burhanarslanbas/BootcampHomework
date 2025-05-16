using AutoMapper;
using BootcampHomework.Business.Dtos.Requests.Application;
using BootcampHomework.Business.Dtos.Responses.Application;
using BootcampHomework.Entities;

namespace Business.Profiles.Brands;
public class MappingProfiles:Profile
{
    public MappingProfiles()
    {
        CreateMap<Application, CreateApplicationRequest>().ReverseMap();
        CreateMap<Application, UpdateApplicationRequest>().ReverseMap();
        CreateMap<Application, DeleteApplicationRequest>().ReverseMap();
        CreateMap<Application, GetByIdApplicationRequest>().ReverseMap();
        CreateMap<Application, CreatedApplicationResponse>().ReverseMap();
        CreateMap<Application, UpdatedApplicationResponse>().ReverseMap();
        CreateMap<Application, DeletedApplicationResponse>().ReverseMap();
        CreateMap<Application, GetApplicationResponse>().ReverseMap();
        CreateMap<Application, GetListApplicationResponse>().ReverseMap();
    }
}
