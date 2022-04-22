using System;
using System.Threading.Tasks;
using Acme.BookStore.Books;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace Acme.BookStore.EntityFrameworkCore.Books
{
    public class BookRepositoryTests : BookStoreEntityFrameworkCoreTestBase
    {
        private readonly IBookRepository _bookRepository;

        public BookRepositoryTests()
        {
            _bookRepository = GetRequiredService<IBookRepository>();
        }

        /*
        [Fact]
        public async Task Test1()
        {
            await WithUnitOfWorkAsync(async () =>
            {
                // Arrange

                // Act

                //Assert
            });
        }
        */
    }
}
