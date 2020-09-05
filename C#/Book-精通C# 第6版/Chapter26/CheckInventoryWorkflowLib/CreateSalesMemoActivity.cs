using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;

namespace CheckInventoryWorkflowLib
{

	public sealed class CreateSalesMemoActivity : CodeActivity
	{
		// 自定义活动的两个属性
		public InArgument<string> Make { get; set; }
		public InArgument<string> Color { get; set; }

		// 如果活动有返回值，则需要继承CodeActivity<TResult>,并在Execute方法中返回该值
		protected override void Execute(CodeActivityContext context)
		{
			//	将消息转存到本地文本文件中
			StringBuilder salesMessage = new StringBuilder();
			salesMessage.AppendLine("***** Attention sales team *****");
			salesMessage.AppendLine("Please order the following ASAP!");
			salesMessage.AppendFormat("1 {0} {1}\n",
				context.GetValue(Color), context.GetValue(Make));
			salesMessage.AppendLine("********************************");

			System.IO.File.WriteAllText("SalesMemo.txt", salesMessage.ToString());
		}
	}
}
