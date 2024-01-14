using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Warehouse.DBClasses;
using WarehouseMG.src.Components.Controller;

namespace WarehouseMG.src.Components.Views.Child.Children.SubChildren
{
    public partial class GoodsFilter : Form
    {
        private GoodFormViews formViewControl;
        private DBuser user = null;

        private CategoryController categ = null;
        private GroupsGoodsController groupsGoodsController = null;
        private GoodsController goodsController = null;

        private List<DBCategory> categList = null;
        private List<DBgroupsGoods> groupsGoods = null;

        public GoodsFilter(DBuser user)
        {

        }
        public GoodsFilter(DBuser user, GoodFormViews formViewControl)
        {
            InitializeComponent();
            this.user = user;

            categ = new CategoryController(this.user);
            groupsGoodsController = new GroupsGoodsController(this.user);
            goodsController = new GoodsController(this.user);

            this.formViewControl = formViewControl;
        }

        public GoodsFilter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GoodsFilter_Load(object sender, EventArgs e)
        {
            this.categList = this.categ.getAllCategory();
            comboCategory.Items.Clear();
            foreach (var s in categList)
            {
                comboCategory.Items.Add(s.categId+"-"+s.categName);
            }

            this.groupsGoods = groupsGoodsController.getAllGroupsGoods();
            txtGroups.Items.Clear();
            foreach (var s in groupsGoods)
            {
                txtGroups.Items.Add(s.groupsId + "-" + s.groupsName);
            }

            //this.goods = goodsController.getAllGoods();
            //foreach (var s in goods)
            //{
            //    txtDate.Items.Add(s.dateStored);
            //}
        }

        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtGroups.Text = "";
            txtGroups.Items.Clear();

            int categBoxIndex = comboCategory.SelectedIndex;
            string categId = categList[categBoxIndex].categId;
            this.groupsGoods = groupsGoodsController.groupsGoodsCategoryIdFilter(categId);
            foreach (var s in groupsGoods)
            {
                txtGroups.Items.Add(s.groupsId + "-" + s.groupsName);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {


            if (!txtGroups.Text.Equals(""))
            {
                int groupsBoxIndex = txtGroups.SelectedIndex;
                string groupsId = groupsGoods[groupsBoxIndex].groupsId;

                List<DBgoods> newGoods = new List<DBgoods>();
                
                newGoods = this.goodsController.goodsGroupsIdFilter(groupsId);

                //this.formViewControl.goods = newGoods;
                this.formViewControl.showGoods(newGoods);
            }

            if (txtGroups.Text.Equals("") && !comboCategory.Text.Equals(""))
            {
                int categBoxIndex = comboCategory.SelectedIndex;
                string categId = categList[categBoxIndex].categId;

                List<DBgoods> newGoods = new List<DBgoods>();
                List<DBgroupsGoods> newGroupsGoods = new List<DBgroupsGoods>();
                newGroupsGoods = this.groupsGoodsController.groupsGoodsCategoryIdFilter(categId);
                foreach (var s in newGroupsGoods)
                {
                    List<DBgoods> newGoods2 = new List<DBgoods>();
                    newGoods2 = goodsController.goodsGroupsIdFilter(s.groupsId);
                    foreach(var k in newGoods2)
                    {
                        newGoods.Add(new DBgoods(
                                k.ID,
                                k.barcode,
                                k.goodsName,
                                k.goodsModel,
                                k.goodsQty,
                                k.goodsDescription,
                                k.goodsDetail,
                                k.dateStored,
                                k.goodsGroups
                            ));
                    }
                }

                //this.formViewControl.goods = newGoods;
                this.formViewControl.showGoods(newGoods);
            }

        }
    }
}
