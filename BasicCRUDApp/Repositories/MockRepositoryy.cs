using BasicCRUDApp.DataBaseContext;
using BasicCRUDApp.Models;

namespace BasicCRUDApp.Repositories
{
    

    public class MockRepositoryy : IRepository
    {

         private readonly ApplicationDbContext context;
        private List<Item> items;
        public MockRepositoryy(ApplicationDbContext context)
        {
            this.context = context;
            items = new List<Item>();
            items.Add(new Item { itemId = 1, itemTitle = "Books" });
            items.Add(new Item { itemId = 2, itemTitle = "Contacts" });
            items.Add(new Item { itemId = 3, itemTitle = "Porducts" });
           

        }

        public IEnumerable<Item> GetItems()
        {
            return items;
        }
    }
}
