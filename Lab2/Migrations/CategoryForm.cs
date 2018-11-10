using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Lab2.Migrations
{
    public partial class CategoryForm : Form
    {
        ProdContext _context;
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            base.OnLoad(e);
            _context = new ProdContext();

            
            _context.Categories.Load();

            this.categoryBindingSource.DataSource =
                _context.Categories.Local.ToBindingList();
        }
    }
}
