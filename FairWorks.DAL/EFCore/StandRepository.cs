using FairWorks.DAL.Abstract;
using FairWorks.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairWorks.DAL.EFCore
{
    public class StandRepository:FairWorksDbRepository<Stand>,IStandRepository
    {
    }
}
