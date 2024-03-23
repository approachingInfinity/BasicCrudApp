using BasicCRUDApp.DataBaseContext;
using BasicCRUDApp.Models;

namespace BasicCRUDApp.Repositories
{
    

    public class MockRepositoryy : IRepository
    {

         private readonly ApplicationDbContext context;
        private readonly List<Item> items;
        public MockRepositoryy(ApplicationDbContext context)
        {
            this.context = context;
            items = new List<Item>();
            items.Add(new Item { itemId = 1, itemTitle = "Books" });
            items.Add(new Item { itemId = 2, itemTitle = "Contacts" });
            items.Add(new Item { itemId = 3, itemTitle = "Products" });
           

        }

        public Book BookById(int id)
        {
            var book = context.books.Find(id);
            return book;
        }

        public void CreateBooks(Book book)
        {
        
            context.books.Add(book);
            context.SaveChanges();
        }

        public async Task DeleteBook(int id)
        {
            var book= await context.books.FindAsync(id);
            if (book != null)
            {
                context.books.Remove(book);
                await context.SaveChangesAsync();
            }
        }

        public IEnumerable<Book> GetBooks()
        {
            return context.books.ToList();
            
        }

        public IEnumerable<Item> GetItems()
        {
            return items;
        }

        public async Task UpdateBook(Book book)
        {
            var b =await context.books.FindAsync(book.BookId);
            if (b != null)
            {
                b.Title = book.Title;
                b.Description = book.Description;
                b.Author = book.Author;
                b.ISBN = book.ISBN;
                b.PublishedDate = book.PublishedDate;
                b.Price = book.Price;
                b.Pages = book.Pages;

               await context.SaveChangesAsync();
            }
        }
    }
}
