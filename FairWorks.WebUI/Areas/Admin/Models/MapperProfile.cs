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
            CreateMap<FirmaBilgi, FirmaBilgiCreateDto>();
            CreateMap<FirmaBilgiCreateDto, FirmaBilgi>();
            CreateMap<UcretsizVerilenAlan,UcretsizVerilenAlanModel>();
            CreateMap<FirmaTipi, FirmaTipiDto>();
            CreateMap<FirmaTipiDto, FirmaTipi>();
            CreateMap<TemsilEttigiFirma,TemsilEttigiFirmaDto>();
            CreateMap<TemsilEttigiFirmaDto, TemsilEttigiFirma>();
            CreateMap<GorusulenFirmaCreateDto, GorusulenFirma>();
            CreateMap<GorusulenFirma, GorusulenFirmaCreateDto>();
            CreateMap<IlaveStandMalzemeler, IlaveStandMalzemelerCreateDto>();
            CreateMap<IlaveStandMalzemelerCreateDto, IlaveStandMalzemeler>();
        }
    }
}
