using HayvanDostu.Core.DAL.EntityFramework;
using HayvanDostu.DAL.Abstarct;
using HayvanDostu.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.DAL.Concrete.EntityFramework.DAL
{
   public class EFVeterinaryDAL : EFRepositoryBase<Veterinary, HayvanDostuDBContext>, IVeterinaryDAL
    {
    }
}
