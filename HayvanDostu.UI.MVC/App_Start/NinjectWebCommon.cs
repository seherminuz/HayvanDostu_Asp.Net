[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Toyzoid.UI.MVC.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(Toyzoid.UI.MVC.App_Start.NinjectWebCommon), "Stop")]

namespace Toyzoid.UI.MVC.App_Start
{
    using System;
    using System.Web;
    using HayvanDostu.BLL.Abstract;
    using HayvanDostu.BLL.Concrete;
    using HayvanDostu.BLL.IOC.Ninject;
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
   

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IPersonalService>().To<PersonalService>();
            kernel.Bind<ICorporateService>().To<CorporateService>();
            kernel.Bind<IPointService>().To<PointService>();
            kernel.Bind<IVeterinaryService>().To<VeterinaryService>();
            kernel.Bind<IChartService>().To<ChartService>();
            kernel.Bind<ICommentService>().To<CommentService>();
            kernel.Bind<IPetService>().To<PetService>();
            kernel.Bind<IPersonalAccommodationService>().To<PersonalAccommodationService>();
            kernel.Bind<IUserRoleService>().To<UserRoleService>();
            kernel.Bind<IPriceService>().To<PriceService>();
            kernel.Bind<IPhotoService>().To<PhotoService>();
            kernel.Bind<IReservationAccommodationService>().To<ReservationAccommodationService>();
            kernel.Bind<IReservationService>().To<ReservationService>();

            kernel.Load<DALModule>();

        }
    }
}
