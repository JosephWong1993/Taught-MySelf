using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.IO;
using System.Linq;
using System.Text;

namespace HelloLinqToSql
{
    static class HellpLinqToSql
    {
        [Table(Name = "Contacts")]
        class Contact
        {
            [Column(IsPrimaryKey = true)]
            public int ContactID { get; set; }

            [Column(Name = "ContactName")]
            public string Name { get; set; }

            [Column]
            public string City { get; set; }
        }

        static void Main(string[] args) 
        {
            string path = @"Database=Northwind;Server=127.0.0.1;uid=sa;Password=931221;";
            DataContext db = new DataContext(path);
            var contacts = from contact in db.GetTable<Contact>()
                           where contact.City == "Paris"
                           select contact;

            foreach (var contact in contacts)
            {
                Console.WriteLine("Bonjour " + contact.Name);
            }

            Console.ReadKey();
        }
    }
}
