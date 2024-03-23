using System.ComponentModel.DataAnnotations;

namespace BasicCRUDApp.Models
{
    public class Book
    {
      
        public int BookId { get; set; }


        public string Title { get; set; }

   
        public string Author { get; set; }

  
        public string Description { get; set; }

     
        public string ISBN { get; set; }

  
        public DateTime PublishedDate { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Please enter a valid price.")]
        public decimal Price { get; set; }

      
        public int Pages { get; set; }

    }
}
