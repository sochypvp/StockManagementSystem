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
    public partial class CustomersFormAdd : Form
    {
        private CustomersForm customersFormController;

        private DBuser user;

        public CustomerController customerController;

        private DBcustomers customers;

        public CustomersFormAdd(DBuser user, CustomersForm customersForm)
        {
            InitializeComponent();
            this.user = user;
            customerController = new CustomerController(this.user);
            btnUpdate.Visible = false;

            customersFormController = customersForm;
        }
        public CustomersFormAdd(DBuser user,DBcustomers dBcustomers,CustomersForm customersForm)
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.Width = 830;
            this.Height = 445;
            this.Text = "Update customer";

            this.user = user;
            customerController = new CustomerController(this.user);
            btnAdd.Visible = false;

            txtName.Text = dBcustomers.cusName;
            txtAddress.Text = dBcustomers.cusAddress;
            txtPosition.Text = dBcustomers.cusPosition;
            txtPhone.Text = dBcustomers.cusPhoneNumber;

            customersFormController = customersForm;

            this.customers = dBcustomers;
        }

        private void CustomersFormAdd_Load(object sender, EventArgs e)
        {
            
        }




        private void btnAdd_Click(object sender, EventArgs e)
        {
            DBcustomers customer = new DBcustomers(
                    txtName.Text.ToString(),
                    txtAddress.Text.ToString(),
                    txtPosition.Text.ToString(),
                    txtPhone.Text.ToString()
                );
            if (customerController.addCustomers(customer))
            {
                MessageBox.Show("Data was inserted !");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            customersFormController.btnViews_Click(sender, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DBcustomers dBcustomers = new DBcustomers();
            dBcustomers.cusId = this.customers.cusId;
            dBcustomers.cusName = txtName.Text;
            dBcustomers.cusAddress = txtAddress.Text;
            dBcustomers.cusPosition = txtPosition.Text;
            dBcustomers.cusPhoneNumber = txtPhone.Text;

            if (customerController.modifyCustomer(dBcustomers))
            {
                MessageBox.Show("Data has updated");
                this.Close();
                customersFormController.btnViews_Click(sender, e);
            }
        }
    }
}
