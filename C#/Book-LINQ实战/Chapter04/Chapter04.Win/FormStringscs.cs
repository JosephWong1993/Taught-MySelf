using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chapter04.Win
{
    public partial class FormStringscs : Form
    {
        public FormStringscs()
        {
            InitializeComponent();
        }

        private void FormStringscs_Load(object sender, EventArgs e)
        {
            String[] books = { "Funny Stories",
                "All your base are belong to us","LINQ rules",
                "C# on Rails","Bonjour mom Amour"};

            var query =
                from book in books
                where book.Length > 10
                orderby book
                select new { Book = book.ToUpper() };

            this.dataGridView1.DataSource = query.ToList();
        }
    }
}
