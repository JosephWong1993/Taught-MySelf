using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalizableDisposableClass
{
    //  高级的资源包装器
    public class MyRsourceWrapper : IDisposable
    {
        //  用来判断Dispose()是否已经被调用
        private bool disposed = false;

        public void Dispose()
        {
            //  调用辅助方法
            //  指定true表示对象用户触发了清理过程


            //  如果用户调用了Dispose()就不需要终结,因此跳过终结
            GC.SuppressFinalize(this);
        }

        private void CleanUp(bool disposing)
        {
            //  保证我们还没被处置
            if (!this.disposed)
            {
                //  如果disposing等于true,释放所有托管的资源
                if (disposing)
                {
                    //  释放托管的资源
                }
                //  在这里清理非托管的资源

                disposed = true;
            }
        }

        ~MyRsourceWrapper()
        {
            Console.Beep();
            //  调用辅助方法.指定false表示GC触发了清理过程
            CleanUp(false);
        }
    }
}
