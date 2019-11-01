using HayvanDostu.DAL.Abstarct;
using HayvanDostu.DAL.Concrete.EntityFramework.DAL;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.BLL.IOC.Ninject
{
    public class DALModule : NinjectModule

    {
        public  override void Load()
        {
            Bind<IPersonalDAL>().To<EFPersonalDAL>();
            Bind<IPointDAL>().To<EFPointDAL>();
            Bind<ICorporateDAL>().To<EFCorporateDAL>();
            Bind<IVeterinaryDAL>().To<EFVeterinaryDAL>();
            Bind<IReservationAccommodationDAL>().To<EFReservationAccommodationDAL>(); 
            Bind<IReservationDAL>().To<EFReservationDAL>();
            Bind<IChartDAL>().To<EFChartDAL>();
            Bind<IPersonalAccommodationDAL>().To<EFPersonalAccommodationDAL>();
            Bind<IPetDAL>().To<EFPetDAL>();
            Bind<IPhotoDAL>().To<EFPhotoDAL>();
            Bind<IPriceDAL>().To<EFPriceDAL>();
            Bind<ICommentDAL>().To<EFCommentDAL>();
            Bind<IUserRoleDAL>().To<EFUserRoleDAL>();


        }
    }
}
