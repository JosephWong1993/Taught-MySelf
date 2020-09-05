using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CommonSnappableTypes;

namespace CSharpSnapIn
{
    [CompanyInfo(CompanyName = "My Company", CompanyUrl = "www.MyCompany.com")]
    public class CSharpModule : IAppFunctionality
    {

        void IAppFunctionality.DoIt()
        {
            MessageBox.Show("You have just used the C# snap in!");
        }
    }
}
