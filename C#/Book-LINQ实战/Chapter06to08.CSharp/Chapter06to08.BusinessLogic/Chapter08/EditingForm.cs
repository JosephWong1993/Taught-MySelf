using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chapter06to08.BusinessLogic.Chapter08
{
  public partial class EditingForm : Form
  {
    public EditingForm()
    {
      InitializeComponent();
    }

    private void EditingForm_Load(object sender, EventArgs e)
    {
        LinqBooksDataContext context = new LinqBooksDataContext();
      var query = from p in context.Publisher
                  select p;
      this.publisherBindingSource.DataSource = query.ToList();
    }
  }
}
