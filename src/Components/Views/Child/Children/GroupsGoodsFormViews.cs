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

namespace WarehouseMG.src.Components.Views.Child.Children
{
    public partial class GroupsGoodsFormViews : Form
    {
        private DBuser user;

        private GroupsGoodsController groupsController;
        private CategoryController categoryController;

        private GroupGoodsForm groupGoodsForm;

        private List<DBCategory> categories;
        public List<DBgroupsGoods> groups;

        public GroupsGoodsFormViews(DBuser user)
        {
            InitializeComponent();
            this.user = user;
            groupsController = new GroupsGoodsController(this.user);
            categoryController = new CategoryController(this.user);

            this.groups = this.groupsController.getAllGroupsGoods();

            //========= Close sort mode on datagridview ==================
            foreach (DataGridViewColumn column in groupsTableView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            
        }
        public GroupsGoodsFormViews(DBuser user,GroupGoodsForm groupGoodsForm)
        {
            InitializeComponent();
            this.user = user;
            groupsController = new GroupsGoodsController(this.user);
            categoryController = new CategoryController(this.user);

            this.groups = this.groupsController.getAllGroupsGoods();

            //========= Close sort mode on datagridview ==================
            foreach (DataGridViewColumn column in groupsTableView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            this.groupGoodsForm = groupGoodsForm;
        }

        public void showGroups(List<DBgroupsGoods> groups)
        {
            groupsTableView.Rows.Clear();
            foreach(var s in groups)
            {
                groupsTableView.Rows.Add(
                        s.groupsId,
                        s.groupsName,
                        s.totalGoods,
                        s.categId
                    );
            }
        }
        private void GroupGoodsFormViews_Load(object sender, EventArgs e)
        {
            showGroups(groupsController.getAllGroupsGoods());

            this.categories = categoryController.getAllCategory();
            listCategory.Items.Add("None");
            foreach(var s in this.categories)
            {
                listCategory.Items.Add(s.categId + "-" + s.categName);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            showGroups(groupsController.getAllGroupsGoods());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = groupsTableView.SelectedRows[0].Index;
            string goodsId = groupsTableView.Rows[index].Cells["gGroupsID"].Value.ToString();

            DialogResult result = MessageBox.Show("Do you wanna delete this groups ?", "Remove item", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (this.groupsController.removeGroupsGoods(goodsId))
                {
                    showGroups(this.groupsController.getAllGroupsGoods());
                }
            }
        }

        private void groupsTableView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void groupsTableView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void listCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listCategory.Text.Equals("None"))
            {
                showGroups(groupsController.getAllGroupsGoods());
            }
            else
            {
                int index = listCategory.SelectedIndex-1;
                string categoryId = this.categories[index].categId;
                showGroups(groupsController.groupsGoodsCategoryIdFilter(categoryId));
            }
        }

        public bool btnCheck = true;
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(groupsTableView.Rows.Count > 0)
            {
                var data = groupsTableView.SelectedRows[0];

                DBgroupsGoods dBgroups = new DBgroupsGoods();
                dBgroups.groupsName = data.Cells[1].Value.ToString();
                dBgroups.categId = data.Cells[3].Value.ToString();
                dBgroups.groupsId = data.Cells[0].Value.ToString();
                GroupsGoodsFormAdd f = new GroupsGoodsFormAdd(this.user,dBgroups, groupGoodsForm);
                f.ShowDialog();
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //DialogResult result = MessageBox.Show("Are you sure ?", "Edit", MessageBoxButtons.YesNo);
            //if (result == DialogResult.Yes)
            //{
            //    //List<DBCategory> listCateg = categoryController.getAllCategory();
            //    for (int i = 0; i < groupsTableView.Rows.Count; i++)
            //    {
            //        string groupsName = groupsTableView.Rows[i].Cells["gGroupsName"].Value.ToString();
            //        string groupsDesc = groupsTableView.Rows[i].Cells["gGroupsDescription"].Value.ToString();

            //        if (!groups[i].groupsName​​.Equals(groupsName) || !groups[i].groupsDescription.Equals(groupsDesc))
            //        {
            //            DBgroupsGoods newGroup = groups[i];
            //            newGroup.groupsName = groupsName;
            //            newGroup.groupsDescription = groupsDesc;

            //            if (groupsController.modifyGroupsGoods(newGroup))
            //            {
            //                btnSave.Visible = false;

            //                groupsTableView.ReadOnly = true;
            //                btnEdit.Text = "Edit";
            //                btnCheck = true;
            //                btnEdit.Image = global::WarehouseMG.Properties.Resources.Edit_Text_File_20px;

            //            }
            //        }
            //    }
            //    showGroups(groupsController.getAllGroupsGoods());
            //}
        }
    }
}
