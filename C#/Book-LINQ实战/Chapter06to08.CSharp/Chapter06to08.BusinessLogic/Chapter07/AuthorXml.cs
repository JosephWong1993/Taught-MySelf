using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;

namespace Chapter06to08.BusinessLogic.Chapter07
{
    public class AuthorXml
    {
        private System.Guid _Id;
        public System.Guid ID
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string WebSite { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
