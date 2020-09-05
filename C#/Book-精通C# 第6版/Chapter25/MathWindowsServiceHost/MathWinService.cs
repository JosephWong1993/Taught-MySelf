using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
//  确保导入这些命名空间
using MathServiceLibrary;
using System.ServiceModel;

namespace MathWindowsServiceHost
{
  public partial class MathWinService : ServiceBase
  {
    //  ServiceHost类型的成员变量
    private ServiceHost myHost;

    public MathWinService()
    {
      InitializeComponent();
    }

    protected override void OnStart(string[] args)
    {
      //  只是为了确保安全
      if (myHost != null)
      {
        myHost.Close();
        myHost = null;
      }

      ////  创建宿主
      //myHost = new ServiceHost(typeof(MathService));

      ////  代码中的ABC
      //Uri address = new Uri("http://localhost:8080/MathServiceLibrary");
      //WSHttpBinding binding = new WSHttpBinding();
      //Type contract = typeof(IBasicMath);

      ////  增加终结点
      //myHost.AddServiceEndpoint(contract, binding, address);

      //  创建宿主,并为HTTP绑定URL
      myHost = new ServiceHost(typeof(MathService),
        new Uri("http://localhost:8080/MathServiceLibrary"));

      //  选择默认的终结点
      myHost.AddDefaultEndpoints();

      //  打开宿主
      myHost.Open();
    }

    protected override void OnStop()
    {
      //  关闭宿主
      if (myHost != null)
      {
        myHost.Close();
      }
    }
  }
}
