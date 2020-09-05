using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace MagicEightBallServiceLib
{
  [ServiceContract(Namespace = "http://MyCompany.com")]
  interface IEightBall
  {
    //  问一个问题,获取答案
    [OperationContract]
    string ObtainAnswerToQuestion(string userQuestion);
  }
}
