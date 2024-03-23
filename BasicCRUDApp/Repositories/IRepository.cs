using BasicCRUDApp.DataBaseContext;
using BasicCRUDApp.Models;

namespace BasicCRUDApp.Repositories
{

    public interface IRepository
    {
        IEnumerable<Item> GetItems();
        IEnumerable<Book> GetBooks();
        void CreateBooks(Book book);
        Book BookById(int id);
        Task UpdateBook(Book book);
        Task DeleteBook(int id);
    }
}
