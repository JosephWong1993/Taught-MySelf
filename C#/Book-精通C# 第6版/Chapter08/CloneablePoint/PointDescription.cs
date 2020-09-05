using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloneablePoint
{
    class PointDescription
    {
        public string PetName { get; set; }
        public Guid PointID { get; set; }

        public PointDescription()
        {
            PetName = "No-name";
            PointID = Guid.NewGuid();
        }
    }
}
