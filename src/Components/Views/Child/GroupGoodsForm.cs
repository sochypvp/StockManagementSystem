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
using WarehouseMG.src.Components.Views.Child.Children;

namespace WarehouseMG.src.Components.Views.Child
{
    public partial class GroupGoodsForm : Form
    {
        private DBuser user;
        public GroupGoodsForm(DBuser user)
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

        private void GroupGoods_Load(object sender, EventArgs e)
        {
            GroupsGoodsFormViews f = new GroupsGoodsFormViews(this.user,this);
            loadForm(f);
        }

        public void btnViews_Click(object sender, EventArgs e)
        {
            GroupsGoodsFormViews f = new GroupsGoodsFormViews(this.user, this);
            loadForm(f);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GroupsGoodsFormAdd f = new GroupsGoodsFormAdd(this.user,this);
            f.ShowDialog();
        }
    }
}
