using SampleMVC_UOW_Pattern.DataAccess.Infrastructure;
using SampleMVC_UOW_Pattern.Service.Repository;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace SampleMVC_UOW_Pattern
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            container.RegisterType<IDbFactory, DbFactory>();
            container.RegisterType<IUnitOfWork, UnitOfWork>();
            container.RegisterType<ICategoryRepository, CategoryRepository>(); 
            container.RegisterType<IProductRepository, ProductRepository>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}