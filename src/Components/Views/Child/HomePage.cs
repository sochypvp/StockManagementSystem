using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Warehouse.DBClasses;
using WarehouseMG.src.Components.Controller;
using ZXing;

namespace WarehouseMG.src.Components.Views.Child
{
    public partial class HomePage : Form
    {
        private DBuser user;
        private CategoryController categoryController;
        private GroupsGoodsController groupsGoodsController;
        private GoodsController goodsController;
        public HomePage(DBuser user)
        {
            InitializeComponent();
            this.user = user;
            categoryController = new CategoryController(this.user);
            groupsGoodsController = new GroupsGoodsController(this.user);
            goodsController = new GoodsController(this.user);
        }

        private void HomePage_Load(object sender, EventArgs e)
        {


            List<DBCategory> dBCategory = categoryController.getAllCategory();

            int totalCateg = 0, totalGroups = 0 ,totalGoods = 0, totalQtyGoods = 0;

            // Set title.
            this.chart1.Titles.Add("ក្រាបបង្ហាញចំនួនទំនិញដែលមាននៅក្នុង categories");

            // Add series.
            for (int i = 0; i < dBCategory.Count; i++)
            {
                // Add series.
                Series series = this.chart1.Series.Add(dBCategory[i].categId+"-"+dBCategory[i].categName);
                series.Label = dBCategory[i].totalGoods;

                // Add point.
                series.Points.Add(Convert.ToInt32(dBCategory[i].totalGoods));

                totalCateg ++;
                totalGroups += Convert.ToInt32(dBCategory[i].totalGroups);
                totalGoods += Convert.ToInt32(dBCategory[i].totalGoods);
            }

            this.totalCateg.Text = totalCateg.ToString();
            this.totalGroups.Text = totalGroups.ToString();
            this.totalGoods.Text = totalGoods.ToString();
            this.totalQtyGoods.Text = goodsController.getAllGoodsQty().ToString();


            //===================================================================

            List<DBgroupsGoods> dBgroupsGoods = groupsGoodsController.getAllGroupsGoods();

            // Set title.
            this.chart2.Titles.Add("ក្រាបបង្ហាញចំនួនទំនិញដែលមាននៅក្នុង groups");

            // Add series.
            for (int i = 0; i < dBgroupsGoods.Count; i++)
            {
                // Add series.
                Series series = this.chart2.Series.Add(dBgroupsGoods[i].groupsId+"-"+dBgroupsGoods[i].groupsName);
                series.Label = dBgroupsGoods[i].totalGoods;

                // Add point.
                series.Points.Add(Convert.ToInt32(dBgroupsGoods[i].totalGoods));

                totalGoods += Convert.ToInt32(dBgroupsGoods[i].totalGoods);
            }

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void totalGroups_Click(object sender, EventArgs e)
        {

        }
    }
}
