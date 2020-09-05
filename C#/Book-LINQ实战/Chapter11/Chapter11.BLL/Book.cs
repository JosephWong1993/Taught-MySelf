using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter11.BLL
{
    public partial class Book
    {
        public IEnumerable<Author> Authors { get; set; }

        public IEnumerable<Review> Reviews { get; set; }
    }
}
