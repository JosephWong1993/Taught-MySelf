using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OldSchoolXml
{
    class Book
    {
        public string Title { get; set; }

        public string Publisher { get; set; }

        public int Year { get; set; }

        public Book(string title, string publisher, int year)
        {
            this.Title = title;
            this.Publisher = publisher;
            this.Year = year;
        }
    }
}
