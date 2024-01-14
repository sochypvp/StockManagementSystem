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
using WarehouseMG.src.Components.Views.Main;

namespace WarehouseMG
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            AuthController authController = new AuthController();
            if (authController.login(txtUsername.Text.ToString(), txtPassword.Text.ToString()))
            {
                DBuser user = authController.User;
                MainForm f = new MainForm(user);
                this.Hide();
                f.ShowDialog();
                this.Dispose();
                this.Close();
            }
            else
            {
                MessageBox.Show("Something cccwas wrong !!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
