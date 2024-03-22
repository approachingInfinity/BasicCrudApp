using BasicCRUDApp.DataBaseContext;
using BasicCRUDApp.Models;

namespace BasicCRUDApp.Repositories
{

    public interface IRepository
    {
        IEnumerable<Item> GetItems();
    }
}
