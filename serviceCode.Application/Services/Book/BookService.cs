
using System.Runtime.CompilerServices;
using serviceCode.Domain.Config;
using Microsoft.Extensions.Options;

namespace serviceCode.Application.Services.Book
{
    public class BookService : IBookService
    {
        private readonly IList<Domain.Config.Book> booksList;

        // IOptions --> Microsoft.Extensions.Options;
        public BookService(IOptions<BookList> options)
        {
            var b = options.Value;
            if(b.Books != null)
                this.booksList = b.Books;
        }

        public async Task<IList<Domain.Config.Book>> GetBooks()
        {
            return this.booksList;
        }
    }
}