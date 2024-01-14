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
using WarehouseMG.src.Components.Controller;

namespace WarehouseMG.src.Components.Views.Child.Children.SubChildren
{
    public partial class CategoryFormAdd : Form
    {
        private CategoryGoodsForm categoryForm;

        public CategoryController categoryController;

        private DBCategory dBCategory;

        private DBuser user = null;
        public CategoryFormAdd(DBuser user, CategoryGoodsForm categoryForm)
        {
            InitializeComponent();
            this.user = user;
            this.categoryForm = categoryForm;
            categoryController = new CategoryController(this.user);
        }
        public CategoryFormAdd(DBuser user,DBCategory dBCategory, CategoryGoodsForm categoryForm)
        {
            InitializeComponent();
            this.user = user;
            this.categoryForm = categoryForm;
            categoryController = new CategoryController(this.user);
            this.dBCategory = dBCategory;

            txtCategoryName.Text = dBCategory.categName;
        }

        private void CategoryFormAdd_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DBCategory category = new DBCategory(txtCategoryName.Text.ToString());
            if (categoryController.addCategory(category))
            {
                categoryForm.btnViews_Click(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            categoryForm.btnViews_Click(sender, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DBCategory dBCategory = new DBCategory();
            dBCategory.categId = this.dBCategory.categId;
            dBCategory.categName = txtCategoryName.Text;
            if (categoryController.modifyCategory(dBCategory))
            {
                MessageBox.Show("Data was updated");
                this.categoryForm.btnViews_Click(sender, e);
                this.Close();
            }
        }
    }
}
