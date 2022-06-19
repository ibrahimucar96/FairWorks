using AutoMapper;
using FairWorks.Domain.Entities;
using FairWorks.WebUI.Areas.Admin.Models.Dto;

namespace FairWorks.WebUI.Areas.Admin.Models
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<BiletliZiyaretci, BiletliZiyaretciDto>();
            CreateMap<BiletliZiyaretciDto, BiletliZiyaretci>();
            CreateMap<DavetiyesizZiyaretci, DavetiyesizZiyaretciDto>();
            CreateMap<DavetiyesizZiyaretciDto, DavetiyesizZiyaretci>();
            CreateMap<Firma,FirmaDto>();
            CreateMap<FirmaDto,Firma>();
            CreateMap<FirmaBilgi, FirmaBilgiDto>();
            CreateMap<FirmaBilgiDto, FirmaBilgi>();
            CreateMap<UcretsizVerilenAlan,UcretsizVerilenAlanModel>();
        }
    }
}
