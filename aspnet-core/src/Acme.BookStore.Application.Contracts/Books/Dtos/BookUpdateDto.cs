using System;
using System.ComponentModel;

namespace Acme.BookStore.Books.Dtos
{
    [Serializable]
    public class BookUpdateDto
    {
        public string Name { get; set; }

        public BookType Type { get; set; }

        public DateTime PublishDate { get; set; }

        public float Price { get; set; }
    }
}