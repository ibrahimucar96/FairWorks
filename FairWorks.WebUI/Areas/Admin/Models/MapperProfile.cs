using AutoMapper;
using FairWorks.Domain.Entities;
using FairWorks.WebUI.Areas.Admin.Models.Dto;

namespace FairWorks.WebUI.Areas.Admin.Models
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<FirmaBilgi, FirmaBilgiDto>();
            CreateMap<FirmaBilgiDto, FirmaBilgi>();
        }
    }
}
