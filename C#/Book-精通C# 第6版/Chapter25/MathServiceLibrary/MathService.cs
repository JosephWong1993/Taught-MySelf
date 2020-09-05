using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MathServiceLibrary
{
  // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的类名“Service1”。
  public class MathService : IBasicMath
  {
    public int Add(int x, int y)
    {
      //  为了模拟长请求
      System.Threading.Thread.Sleep(5000);
      return x + y;
    }
  }
}
