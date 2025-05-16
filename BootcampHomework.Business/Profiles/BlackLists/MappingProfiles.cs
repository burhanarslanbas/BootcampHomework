using AutoMapper;
using BootcampHomework.Business.Dtos.Requests.BlackList;
using BootcampHomework.Business.Dtos.Responses.BlackList;
using BootcampHomework.Entities;

namespace BootcampHomework.Business.Profiles.BlackLists;
public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<BlackList, CreateBlackListRequest>().ReverseMap();
        CreateMap<BlackList, UpdateBlackListRequest>().ReverseMap();
        CreateMap<BlackList, DeleteBlackListRequest>().ReverseMap();
        CreateMap<BlackList, GetByIdBlackListRequest>().ReverseMap();
        CreateMap<BlackList, CreatedBlackListResponse>().ReverseMap();
        CreateMap<BlackList, UpdatedBlackListResponse>().ReverseMap();
        CreateMap<BlackList, DeletedBlackListResponse>().ReverseMap();
        CreateMap<BlackList, GetBlackListResponse>().ReverseMap();
        CreateMap<BlackList, GetListBlackListResponse>().ReverseMap();
    }
}