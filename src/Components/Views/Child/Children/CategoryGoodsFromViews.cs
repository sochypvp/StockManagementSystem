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
using WarehouseMG.src.Components.Views.Child.Children.SubChildren;

namespace WarehouseMG.src.Components.Views.Child.Children
{
    public partial class CategoryGoodsFromViews : Form
    {
        private DBuser user = null;
        private CategoryController categoryController;

        private CategoryGoodsForm categoryGoodsForm;

        public List<DBCategory> listCateg;

        public CategoryGoodsFromViews(DBuser user, CategoryGoodsForm categoryGoodsForm)
        {
            InitializeComponent();
            this.user = user;
            categoryController = new CategoryController(this.user);

            listCateg = categoryController.getAllCategory();
            this.categoryGoodsForm = categoryGoodsForm;
        }

        public void showCategory(List<DBCategory> category)
        {
            categoryTableView.Rows.Clear();
            foreach(var s in category)
            {
                categoryTableView.Rows.Add(
                    s.categId,
                    s.categName,
                    s.totalGroups,
                    s.totalGoods
                    );
            }
        }
        public void showCategory()
        {
            List<DBCategory> categories = new List<DBCategory>();
            categories = this.categoryController.getAllCategory();
            categoryTableView.Rows.Clear();
            foreach (var s in categories)
            {
                categoryTableView.Rows.Add(
                    s.categId,
                    s.categName,
                    s.totalGroups,
                    s.totalGoods
                    );
            }
        }

        private void CategoryGoodsFromViews_Load(object sender, EventArgs e)
        {
            List<DBCategory> categories = new List<DBCategory>();
            categories = this.categoryController.getAllCategory();
            showCategory(categories);

            //========= Close sort mode on datagridview ==================
            foreach (DataGridViewColumn column in categoryTableView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        public bool btnCheck = true;
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //if(btnCheck)
            //{
            //    categoryTableView.ReadOnly = false;
            //    categoryTableView.Columns[0].ReadOnly = true;
            //    categoryTableView.Columns[2].ReadOnly = true;
            //    categoryTableView.Columns[3].ReadOnly = true;
            //    btnEdit.Text = "Cancel";
            //    btnCheck = false;
            //    btnEdit.Image = global::WarehouseMG.Properties.Resources.cancel_20px;
            //}
            //else
            //{
            //    categoryTableView.ReadOnly = true;
            //    btnEdit.Text = "Edit";
            //    btnCheck = true;
            //    btnEdit.Image = global::WarehouseMG.Properties.Resources.Edit_Text_File_20px;

            //}
            if(categoryTableView.Rows.Count > 0)
            {
                var data = categoryTableView.SelectedRows[0];
                DBCategory dBCategory = new DBCategory();
                dBCategory.categId = data.Cells[0].Value.ToString();
                dBCategory.categName = data.Cells[1].Value.ToString();
                CategoryFormAdd f = new CategoryFormAdd(this.user,dBCategory, categoryGoodsForm);
                f.ShowDialog();
            }
            
        }

        private void categoryTableView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void categoryTableView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            btnSave.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure ?","Edit",MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                //List<DBCategory> listCateg = categoryController.getAllCategory();
                for (int i = 0; i < categoryTableView.Rows.Count; i++)
                {
                    string categName = categoryTableView.Rows[i].Cells["gCategoryName"].Value.ToString();
                    if (!listCateg[i].categName.Equals(categName))
                    {
                        DBCategory newCategory = listCateg[i];
                        newCategory.categName = categName;
                        if (categoryController.modifyCategory(newCategory))
                        {
                            btnSave.Visible = false;

                            categoryTableView.ReadOnly = true;
                            btnEdit.Text = "Edit";
                            btnCheck = true;
                            btnEdit.Image = global::WarehouseMG.Properties.Resources.Edit_Text_File_20px;

                            
                        }
                    }
                }
                showCategory();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            showCategory();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = categoryTableView.SelectedRows[0].Index;
            string categId = categoryTableView.Rows[index].Cells["gCategoryID"].Value.ToString();

            DialogResult result = MessageBox.Show("Do you wanna delete this category ?", "Remove item", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (this.categoryController.removeCategory(categId))
                {
                    showCategory();
                }
            }
        }
    }
}
