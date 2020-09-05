﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//  代理所在的位置
using MagicEightBallServiceClient.ServiceReference1;

namespace MagicEightBallServiceClient
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Ask the Magic 8 Ball *****\n");

      //using (EightBallClient ball = new EightBallClient("NetTcpBinding_IEightBall"))
      using (EightBallClient ball = new EightBallClient("BasicHttpBinding_IEightBall"))
      {
        Console.WriteLine("Your question:");
        string question = Console.ReadLine();
        string answer = ball.ObtainAnswerToQuestion(question);
        Console.WriteLine("8-Ball says:{0}", answer);
      }

      Console.ReadLine();
    }
  }
}
