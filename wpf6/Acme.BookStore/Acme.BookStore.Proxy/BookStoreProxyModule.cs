using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace Acme.BookStore.Proxy
{
    [DependsOn(typeof(AbpHttpClientModule))]
    [DependsOn(typeof(BookStoreApplicationContractsModule))]
    public class BookStoreProxyModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            // Prepare for static client proxy generation
            context.Services.AddStaticHttpClientProxies(
                typeof(BookStoreApplicationContractsModule).Assembly
            );

            
        }
    }
}
