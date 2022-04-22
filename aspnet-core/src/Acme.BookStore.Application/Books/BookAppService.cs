using System;
using Acme.BookStore.Permissions;
using Acme.BookStore.Books.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.Books
{
    public class BookAppService : CrudAppService<Book, BookDto, Guid, PagedAndSortedResultRequestDto, BookCreateDto, BookUpdateDto>,
        IBookAppService
    {
        protected override string GetPolicyName { get; set; } = BookStorePermissions.Book.Default;
        protected override string GetListPolicyName { get; set; } = BookStorePermissions.Book.Default;
        protected override string CreatePolicyName { get; set; } = BookStorePermissions.Book.Create;
        protected override string UpdatePolicyName { get; set; } = BookStorePermissions.Book.Update;
        protected override string DeletePolicyName { get; set; } = BookStorePermissions.Book.Delete;

        private readonly IBookRepository _repository;
        
        public BookAppService(IBookRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
