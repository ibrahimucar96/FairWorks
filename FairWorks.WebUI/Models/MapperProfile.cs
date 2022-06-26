using AutoMapper;
using FairWorks.Domain.Entities;
using FairWorks.WebUI.Models.Dto;

namespace FairWorks.WebUI.Models
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<LoginDto, Kullanici>();
            CreateMap<Kullanici, LoginDto>();
            CreateMap<RegisterDto, Kullanici>();
            CreateMap<Kullanici,RegisterDto>();
        }
    }
}
