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
using WarehouseMG.src.Components.Views.Child.Children;

namespace WarehouseMG.src.Components.Views.Child
{
    public partial class GoodsForm : Form
    {
        private DBuser user;

        public GoodFormViews formView = null;
        public GoodFormAdd formAdd = null;
        public GoodsForm(DBuser user)
        {
            InitializeComponent();
            this.user = user;
            formView = new GoodFormViews(this.user,this);
            formAdd = new GoodFormAdd(this.user);
        }
        public void loadForm(Form f)
        {
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            pContainer.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }

        private void GoodsForm_Load(object sender, EventArgs e)
        {
            loadForm(formView);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        public void button2_Click(object sender, EventArgs e)
        {
            GoodFormAdd f = new GoodFormAdd(this.user, this);
            loadForm(f);
            //loadForm(formAdd);
        }

        public void btnViews_Click(object sender, EventArgs e)
        {
            GoodFormViews f = new GoodFormViews(this.user, this);
            loadForm(f);
            //loadForm(formView);
        }
    }
}
