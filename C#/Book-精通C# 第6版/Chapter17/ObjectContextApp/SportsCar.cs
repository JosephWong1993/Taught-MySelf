using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Remoting.Contexts;
using System.Threading;

namespace ObjectContextApp
{
    class SportsCar
    {
        public SportsCar()
        {
            //  得到上下文信息,并输出上下文ID
            Context ctx = Thread.CurrentContext;
            Console.WriteLine("{0} object in context {1}",
                this.ToString(), ctx.ContextID);
            foreach (IContextProperty itfCtxProp in ctx.ContextProperties)
            {
                Console.WriteLine("-> Ctx Prop: {0}", itfCtxProp.Name);
            }
        }
    }
}
