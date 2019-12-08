using HayvanDostu.Core.DAL.EntityFramework;
using HayvanDostu.DAL.Abstarct;
using HayvanDostu.Model;

namespace HayvanDostu.DAL.Concrete.EntityFramework.DAL
{
    public class EFChartDAL : EFRepositoryBase<Chart, HayvanDostuDBContext>, IChartDAL
    {
    }
}
