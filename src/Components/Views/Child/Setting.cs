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
using WarehouseMG.src.Components.Views.Child.Children.FormSetting;

namespace WarehouseMG.src.Components.Views.Child
{
    public partial class Setting : Form
    {
        private DBuser user;
        public Setting(DBuser user)
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
        private void Setting_Load(object sender, EventArgs e)
        {
            PrinterSetting f = new PrinterSetting(this.user);
            loadForm(f);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrinterSetting f = new PrinterSetting(this.user);
            loadForm(f);
        }
    }
}
