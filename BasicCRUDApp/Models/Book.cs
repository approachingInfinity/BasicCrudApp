﻿namespace BasicCRUDApp.Models
{
    public class Book
    {
      
        public int BookId { get; set; }


        public string Title { get; set; }

   
        public string Author { get; set; }

  
        public string Description { get; set; }

     
        public string ISBN { get; set; }

  
        public DateTime PublishedDate { get; set; }

      
        public decimal Price { get; set; }

      
        public int Pages { get; set; }

    }
}
