using Acme.BookStore.Books;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.DependencyInjection;

namespace Acme.BookStore.Client
{
    public class HelloWorldService : ITransientDependency
    {
        public ILogger<HelloWorldService> Logger { get; set; }
        private readonly IBookAppService _bookAppService;

        public HelloWorldService(IBookAppService bookAppService) 
        {
            Logger = NullLogger<HelloWorldService>.Instance;
            _bookAppService = bookAppService;
        }
        public string SayHello()
        {
            Logger.LogInformation("Call SayHello");
            return "Hello world!";
        }


        public async Task TestProxy()
        {
            PagedAndSortedResultRequestDto dto = new PagedAndSortedResultRequestDto();
            var res = await _bookAppService.GetListAsync(dto);
            ;
        }

    }
}
