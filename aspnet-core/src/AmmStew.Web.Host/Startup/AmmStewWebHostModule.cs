using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AmmStew.Configuration;

namespace AmmStew.Web.Host.Startup
{
    [DependsOn(
       typeof(AmmStewWebCoreModule))]
    public class AmmStewWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AmmStewWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AmmStewWebHostModule).GetAssembly());
        }
    }
}
