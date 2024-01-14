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
using WarehouseMG.src.Components.Views.Child;

namespace WarehouseMG.src.Components.Views.Main
{
    public partial class MainForm : Form
    {
        private DBuser user = null;
        public MainForm(DBuser user)
        {
            InitializeComponent();
            this.user = user;
        }
        public MainForm()
        {
            InitializeComponent();
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

        public void buttonCliked(Button btn)
        {
            btnHome.BackColor = SystemColors.ButtonFace;
            btnGoods.BackColor = SystemColors.ButtonFace;
            btnCategory.BackColor = SystemColors.ButtonFace;
            btnGroupsGoods.BackColor = SystemColors.ButtonFace;
            btnCustomer.BackColor = SystemColors.ButtonFace;
            btnOrder.BackColor = SystemColors.ButtonFace;
            btnReport.BackColor = SystemColors.ButtonFace;
            btnSetting.BackColor = SystemColors.ButtonFace;

            btn.BackColor = SystemColors.GradientActiveCaption;
        }

        //============ Event =============================================
        private void MainForm_Load(object sender, EventArgs e)
        {
            HomePage f = new HomePage(this.user);
            loadForm(f);
            buttonCliked(btnHome);
        }

        private void btnGoods_Click(object sender, EventArgs e)
        {
            GoodsForm f = new GoodsForm(this.user);
            loadForm(f);
            buttonCliked(btnGoods);
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            CategoryGoodsForm f = new CategoryGoodsForm(this.user);
            loadForm(f);
            buttonCliked(btnCategory);
        }

        private void btnGroupsGoods_Click(object sender, EventArgs e)
        {
            GroupGoodsForm f = new GroupGoodsForm(this.user);
            loadForm(f);
            buttonCliked(btnGroupsGoods);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("You wanna log out ?", "Sign out", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                Login f = new Login();
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            CustomersForm f = new CustomersForm(this.user);
            loadForm(f);
            buttonCliked(btnCustomer);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            OrderGoods f = new OrderGoods(this.user);
            loadForm(f);
            buttonCliked(btnOrder);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            FormReport f = new FormReport(this.user);
            loadForm(f);
            buttonCliked(btnReport);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomePage f = new HomePage(this.user);
            loadForm(f);
            buttonCliked(btnHome);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Setting f = new Setting(this.user);
            loadForm(f);
            buttonCliked(btnSetting);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
