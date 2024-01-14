using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse.DBClasses;
using WarehouseMG.src.Components.Views.Child.Children;
using WarehouseMG.src.Components.Views.Child.Children.SubChildren;

namespace WarehouseMG.src.Components.Views.Child
{
    public partial class CategoryGoodsForm : Form
    {
        private DBuser user = null;
        public CategoryGoodsForm(DBuser user)
        {
            InitializeComponent();
            this.user = user;
        }

        //Load form
        public void loadForm(Form f)
        {
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            pContainer.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }

        private void CategoryGoodsForm_Load(object sender, EventArgs e)
        {
            CategoryGoodsFromViews f = new CategoryGoodsFromViews(this.user,this);
            loadForm(f);
        }

        public void btnViews_Click(object sender, EventArgs e)
        {
            CategoryGoodsFromViews f = new CategoryGoodsFromViews(this.user,this);
            loadForm(f);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CategoryFormAdd f = new CategoryFormAdd(this.user,this);
            f.ShowDialog();
        }
    }
}
