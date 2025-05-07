using serviceCode.Domain.Config;

namespace serviceCode.Application.Services.Book
{
    public interface IBookService
    {
        Task<IList<Domain.Config.Book>> GetBooks();
    }
}