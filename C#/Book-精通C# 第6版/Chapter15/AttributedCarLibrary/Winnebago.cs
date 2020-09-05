using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AttributedCarLibrary
{
    [VehicleDescription("A very long, slow, but feature-rich auto")]
    public class Winnebago
    {
        //  Ulong类型不符合CLS
        public ulong notCompliant;

        //[VehicleDescription("My rocking CD player")]
        public void PlayMusic(bool On)
        {
            //  ...
        }
    }
}
