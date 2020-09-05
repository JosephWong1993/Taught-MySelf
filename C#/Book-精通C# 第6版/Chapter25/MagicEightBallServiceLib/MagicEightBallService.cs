using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace MagicEightBallServiceLib
{
  public class MagicEightBallService : IEightBall
  {
    //  只是为了在宿主上显示
    public MagicEightBallService()
    {
      Console.WriteLine("The 8-Ball awaits your question...");
    }

    public string ObtainAnswerToQuestion(string userQuestion)
    {
      string[] answers = { "Future Uncertain", "Yes", "No", "Hazy", "Ask again later", "Definitely" };

      //  返回随机的响应
      Random r = new Random();
      return answers[r.Next(answers.Length)];
    }
  }
}
