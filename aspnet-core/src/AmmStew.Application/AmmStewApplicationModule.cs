using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AmmStew.Authorization;

namespace AmmStew
{
    [DependsOn(
        typeof(AmmStewCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AmmStewApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AmmStewAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AmmStewApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
