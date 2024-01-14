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
    public partial class GroupsGoodsFormAdd : Form
    {
        private CategoryController categoryController;
        private GroupsGoodsController groupsController;

        private GroupGoodsForm groupGoodsForm;

        private DBuser user;
        private DBgroupsGoods dBgroupsGoods;
        public List<DBCategory> categories;
        public GroupsGoodsFormAdd(DBuser user, GroupGoodsForm groupGoodsForm)
        {
            InitializeComponent();
            this.user = user;
            groupsController = new GroupsGoodsController(this.user);
            categoryController = new CategoryController(this.user);

            btnUpdate.Visible = false;

            this.groupGoodsForm = groupGoodsForm;
        }
        public GroupsGoodsFormAdd(DBuser user,DBgroupsGoods dBgroupsGoods,GroupGoodsForm groupGoodsForm)
        {
            InitializeComponent();
            this.user = user;
            groupsController = new GroupsGoodsController(this.user);
            categoryController = new CategoryController(this.user);

            txtName.Text = dBgroupsGoods.groupsName;
            List<DBCategory> dBCategory = categoryController.getCategoryById(dBgroupsGoods.categId);
            listCategory.Text = dBCategory[0].categId + "-" + dBCategory[0].categName;

            btnAdd.Visible = false;

            this.groupGoodsForm = groupGoodsForm;
            this.dBgroupsGoods = dBgroupsGoods;
        }
        //========== Public Var ==================================
        //========================================================

        private void GroupsGoodsFormAdd_Load(object sender, EventArgs e)
        {
            categories = categoryController.getAllCategory();
            foreach (var s in categories)
            {
                listCategory.Items.Add(s.categId+"-"+s.categName);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!txtName.Text.Equals(""))
            {

                if (!listCategory.Text.Equals(""))
                {
                    string newCateg = listCategory.Text.ToString();
                    string[] categId = newCateg.Split('-');

                    DBgroupsGoods dBgroupsGoods = new DBgroupsGoods(
                            txtName.Text.ToString(),
                            categId[0]
                        );

                    if (groupsController.addGroupsGoods(dBgroupsGoods))
                    {
                        MessageBox.Show("Data was inserted !");
                        this.groupGoodsForm.btnViews_Click(sender, e);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please select category");
                }
            }
            else
            {
                MessageBox.Show("Please enter goups Name");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string newCateg = listCategory.Text.ToString();
            string[] categId = newCateg.Split('-');
            DBgroupsGoods dBgroups = new DBgroupsGoods();
            dBgroups.groupsName = txtName.Text;
            dBgroups.categId = categId[0];
            dBgroups.groupsId = this.dBgroupsGoods.groupsId;

            if (groupsController.modifyGroupsGoods(dBgroups))
            {
                MessageBox.Show("Data was updated");
                this.groupGoodsForm.btnViews_Click(sender, e);
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.groupGoodsForm.btnViews_Click(sender, e);
            this.Close();
        }
    }
}
