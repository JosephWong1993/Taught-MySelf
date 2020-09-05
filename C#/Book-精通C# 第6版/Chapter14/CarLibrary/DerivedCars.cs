using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarLibrary
{
    public class SportsCar : Car
    {
        public SportsCar()
        {

        }
        public SportsCar(string name, int max, int currSp)
            : base(name, max, currSp)
        {

        }

        public override void TurboBoost()
        {
            MessageBox.Show("Ramming speed!", "Fater is better...");
        }
    }

    public class MiniVan : Car
    {
        public MiniVan()
        {

        }
        public MiniVan(string name, int maxSp, int currSp)
            : base(name, maxSp, currSp)
        {

        }

        public override void TurboBoost()
        {
            //  Minivans引擎马力不足
            egnState = EngineState.engineDead;
            MessageBox.Show("Eek!", "Your engine block exploded");
        }
    }
}
