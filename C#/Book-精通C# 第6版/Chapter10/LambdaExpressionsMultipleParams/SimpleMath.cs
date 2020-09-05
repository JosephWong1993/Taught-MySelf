using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LambdaExpressionsMultipleParams
{
    public class SimpleMath
    {
        public delegate void MathMessage(string msg, int result);
        private MathMessage mmDelegate;

        public void SetMathHandler(MathMessage target)
        {
            mmDelegate = target;
        }

        public void Add(int x, int y)
        {
            if (mmDelegate != null)
            {
                mmDelegate.Invoke("Adding has completed!", x + y);
            }
        }
    }
}
