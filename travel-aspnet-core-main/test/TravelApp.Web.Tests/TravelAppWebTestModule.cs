using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TravelApp.EntityFrameworkCore;
using TravelApp.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace TravelApp.Web.Tests
{
    [DependsOn(
        typeof(TravelAppWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class TravelAppWebTestModule : AbpModule
    {
        public TravelAppWebTestModule(TravelAppEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TravelAppWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(TravelAppWebMvcModule).Assembly);
        }
    }
}