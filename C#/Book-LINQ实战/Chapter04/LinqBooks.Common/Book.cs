using System;

namespace LinqBooks.Common
{
    public class Book
    {
        public string Title { get; set; }

        public Publisher Publisher { get; set; }

        public Author[] Authors { get; set; }

        public int PageCount { get; set; }

        public decimal Price { get; set; }

        public DateTime PublicationDate { get; set; }

        public string Isbn { get; set; }
    }
}