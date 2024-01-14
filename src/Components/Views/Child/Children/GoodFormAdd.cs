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
    public partial class GoodFormAdd : Form
    {
        private GoodsForm goodsFormController;

        private DBuser user = null;
        private CategoryController categoryController = null;
        private GroupsGoodsController groupsGoodsController = null;
        private GoodsController goodsController = null;
        private DBgoods goods = null;

        private List<DBCategory> categoryCollection = null;
        private List<DBgroupsGoods> groupsGoods = null;
        public GoodFormAdd(DBuser user)
        {
            InitializeComponent();
            this.user = user;
            categoryController = new CategoryController(this.user);
            groupsGoodsController = new GroupsGoodsController(this.user);
            goodsController = new GoodsController(this.user);

            btnUpdate.Visible = false;
        }
        public GoodFormAdd(DBuser user, GoodsForm goodsForm)
        {
            InitializeComponent();

            this.goodsFormController = goodsForm;

            this.user = user;
            categoryController = new CategoryController(this.user);
            groupsGoodsController = new GroupsGoodsController(this.user);
            goodsController = new GoodsController(this.user);

            btnUpdate.Visible = false;
        }
        public GoodFormAdd(DBuser user,DBgoods goods, GoodsForm goodsForm)
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.Width = 830;
            this.Height = 445;
            this.Text = "Update goods";

            this.goodsFormController = goodsForm;

            this.user = user;
            categoryController = new CategoryController(this.user);
            groupsGoodsController = new GroupsGoodsController(this.user);
            goodsController = new GoodsController(this.user);

            this.goods = goods;

            btnAdd.Visible = false;
            btnReset.Visible = false;


            //============= Update data =====================================
            txtGroups.Text = goods.goodsGroups;
            txtBarcode.Text = goods.barcode;
            txtName.Text = goods.goodsName;
            txtModel.Text = goods.goodsModel;
            txtDesc.Text = goods.goodsDescription;
            txtDetails.Text = goods.goodsDetail;
            txtQty.Text = goods.goodsQty;

            string groupsId = "";
            foreach(var s in this.groupsGoodsController.groupsGoodsIdFilter(goods.goodsGroups))
            {
                groupsId = s.groupsId + "-" + s.groupsName;
            }
            txtGroups.Text = groupsId;
        }

        private void GoodFormAdd_Load(object sender, EventArgs e)
        {
            List<DBCategory> categories = new List<DBCategory>();
            categories = categoryController.getAllCategory();
            categoryCollection = categories;
            foreach(var s in categories)
            {
                txtCategory.Items.Add(s.categId+"-"+s.categName);
            }

            this.groupsGoods = new List<DBgroupsGoods>();
            this.groupsGoods = groupsGoodsController.getAllGroupsGoods();
            foreach (var s in groupsGoods)
            {
                txtGroups.Items.Add(s.groupsId + "-" + s.groupsName);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!txtGroups.Text.Equals(""))
            {
                int groupsGoodsBoxIndex = txtGroups.SelectedIndex;

                DBgoods goods = new DBgoods(
                        txtBarcode.Text.ToString(),
                        txtName.Text.ToString(),
                        txtModel.Text.ToString(),
                        txtDesc.Text.ToString(),
                        txtDetails.Text.ToString(),
                        this.groupsGoods[groupsGoodsBoxIndex].groupsId
                    );
                goods.goodsQty = txtQty.Text.ToString();
                if (goodsController.addGoods(goods))
                {
                    MessageBox.Show("Data was inserted !");
                    txtCategory.Text = "";
                    txtGroups.Text = "";
                    txtBarcode.Text = "";
                    txtName.Text = "";
                    txtModel.Text = "";
                    txtDesc.Text = "";
                    txtDetails.Text = "";
                    txtQty.Value = 0;
                }
                else
                {
                    MessageBox.Show("Someting was wrong !");
                }
            }
            else
            {
                MessageBox.Show("Please select groups !");
            }

        }

        private void txtCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtGroups.Text = "";
            txtGroups.Items.Clear();

            int comboIndex = txtCategory.SelectedIndex;
            string categId = categoryCollection[comboIndex].categId;
            this.groupsGoods = new List<DBgroupsGoods>();
            this.groupsGoods = groupsGoodsController.groupsGoodsCategoryIdFilter(categId);
            foreach (var s in groupsGoods)
            {
                txtGroups.Items.Add(s.groupsId + "-" + s.groupsName);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!txtGroups.Text.Equals(""))
            {
                string groupsId = txtGroups.Text.ToString();
                string[] newGroupsId = groupsId.Split('-');

                DBgoods newGoods = new DBgoods(
                        this.goods.ID,
                        txtBarcode.Text.ToString(),
                        txtName.Text.ToString(),
                        txtModel.Text.ToString(),
                        txtDesc.Text.ToString(),
                        txtDetails.Text.ToString(),
                        newGroupsId[0]
                    );
                newGoods.goodsQty = txtQty.Text.ToString();
                if (goodsController.modifyGoods(newGoods))
                {
                    MessageBox.Show("Data was modify !");
                    this.Close();
                    this.goodsFormController.btnViews_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Someting was wrong !");
                }
            }
            else
            {
                MessageBox.Show("Please select groups !");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.goodsFormController.btnViews_Click(sender, e);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            goodsFormController.button2_Click(sender, e);
        }
    }
}
