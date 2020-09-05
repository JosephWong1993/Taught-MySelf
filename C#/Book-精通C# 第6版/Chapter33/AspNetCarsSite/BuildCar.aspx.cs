using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BuildCardPage : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void carWizard_FinishButtonClick(object sender, WizardNavigationEventArgs e)
    {
        //  得到每一个值
        string order = string.Format("{0}, your {1} {2} will arrive on {3}.",
            txtCarPetName.Text, ListBoxColors.SelectedValue,
            txtCarModel.Text,
            carCalendar.SelectedDate.ToShortDateString());

        //  赋值给标签
        lblOrder.Text = order;
    }
}