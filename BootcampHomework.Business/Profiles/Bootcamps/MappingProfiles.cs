using AutoMapper;
using BootcampHomework.Business.Dtos.Requests.Bootcamp;
using BootcampHomework.Business.Dtos.Responses.Bootcamp;
using BootcampHomework.Entities;

namespace BootcampHomework.Business.Profiles.Bootcamps;
public class MappingProfiles: Profile
{
    public MappingProfiles()
    {
        CreateMap<Bootcamp, CreateBootcampRequest>().ReverseMap();
        CreateMap<Bootcamp, UpdateBootcampRequest>().ReverseMap();
        CreateMap<Bootcamp, DeleteBootcampRequest>().ReverseMap();
        CreateMap<Bootcamp, GetByIdBootcampRequest>().ReverseMap();
        CreateMap<Bootcamp, CreatedBootcampResponse>().ReverseMap();
        CreateMap<Bootcamp, UpdatedBootcampResponse>().ReverseMap();
        CreateMap<Bootcamp, DeletedBootcampResponse>().ReverseMap();
        CreateMap<Bootcamp, GetBootcampResponse>().ReverseMap();
        CreateMap<Bootcamp, GetListBootcampResponse>().ReverseMap();
    }
}