using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventoryEDMConsoleApp
{
  public partial class Car
  {
    public override string ToString()
    {
      //  由于PetName列可能为空字符串,因此提供默认值"**No Name**"
      return string.Format("{0} is a {1} {2} with ID {3}.",
        this.CarNickname ?? "**No Name**",
        this.Color, this.Make, this.CarID);
    }

    partial void OnCarNicknameChanging(string value)
    {
      Console.WriteLine("\t-> Changing name to: {0}", value);
    }

    partial void OnCarNicknameChanged()
    {
      Console.WriteLine("\t-> Name of car has been changed!");
    }
  }
}
