using FairWorks.Domain.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace FairWorks.WebUI.Areas.Admin.Models.Dto
{
    public class FirmaBilgiCreateDto
    {
        public FirmaBilgiDto FirmaBilgiDto { get; set; }
        public SelectList UcretsizVerilenAlan { get; set; }
    }
}
