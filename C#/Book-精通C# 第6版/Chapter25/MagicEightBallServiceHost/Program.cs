using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using MagicEightBallServiceLib;

namespace MagicEightBallServiceHost
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Console Based WCF Host *****");

      using (ServiceHost serviceHost = new ServiceHost(typeof(MagicEightBallService)))
      {
        //  打开宿主并且开启对传入消息的监听
        serviceHost.Open();
        DisplayHostInfo(serviceHost);

        //  使服务保持运行状态,直到Enter键被按下
        Console.WriteLine("The service is ready.");
        Console.WriteLine("Press the Enter key to terminate service.");
        Console.ReadLine();
      }
    }

    static void DisplayHostInfo(ServiceHost host)
    {
      Console.WriteLine();
      Console.WriteLine("***** Host Info *****");

      foreach (System.ServiceModel.Description.ServiceEndpoint se in host.Description.Endpoints)
      {
        Console.WriteLine("Address: {0}", se.Address);
        Console.WriteLine("Binding: {0}", se.Binding);
        Console.WriteLine("Contract: {0}", se.Contract);
        Console.WriteLine();
      }

      Console.WriteLine("********************");
    }
  }
}
