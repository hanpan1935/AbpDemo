using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Modularity;
using Volo.Abp.Autofac;
using Acme.BookStore.Proxy;

namespace Acme.BookStore.Client
{
    [DependsOn(typeof(BookStoreProxyModule))]
    public class BookStoreClientModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddSingleton<MainWindow>();
        }
    }
}
