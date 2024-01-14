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
    public partial class CustomersFormViews : Form
    {
        private CustomersForm customersFormController;

        private DBuser user;

        public CustomerController customerController;

        public DBcustomers customers;

        public CustomersFormViews(DBuser user,CustomersForm customersForm)
        {
            InitializeComponent();
            this.user = user;
            customerController = new CustomerController(this.user);
            customersFormController = customersForm;
        }


        public void showCustomerData(List<DBcustomers> dBcustomers)
        {
            customersTableView.Rows.Clear();
            foreach (var s in dBcustomers)
            {
                customersTableView.Rows.Add(
                        s.cusId,
                        s.cusName,
                        s.cusAddress,
                        s.cusPosition,
                        s.cusPhoneNumber
                    );
            }
        }

        private void CustomersFormViews_Load(object sender, EventArgs e)
        {
            showCustomerData(customerController.getAllCustomers());


            //========= Close sort mode on datagridview ==================
            foreach (DataGridViewColumn column in customersTableView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        
        public bool btnCheck = true;
        private void btnEdit_Click(object sender, EventArgs e)
        {
            var data = customersTableView.SelectedRows[0];
            DBcustomers dBcustomers = new DBcustomers();
            dBcustomers.cusId = data.Cells[0].Value.ToString();
            dBcustomers.cusName = data.Cells[1].Value.ToString();
            dBcustomers.cusAddress = data.Cells[2].Value.ToString();
            dBcustomers.cusPosition = data.Cells[3].Value.ToString();
            dBcustomers.cusPhoneNumber = data.Cells[4].Value.ToString();

            CustomersFormAdd f = new CustomersFormAdd(this.user,dBcustomers,customersFormController);
            //customersFormController.loadForm(f);
            f.ShowDialog();
        }

        private void customersTableView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            customersFormController.btnViews_Click(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(customersTableView.Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure ?", "Remove customer", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    string cusId = customersTableView.SelectedRows[0].Cells[0].Value.ToString();
                    if (customerController.removeCustomer(cusId))
                    {
                        MessageBox.Show("Data was deleted ");
                        showCustomerData(customerController.getAllCustomers());
                    }
                    else
                    {
                        MessageBox.Show("Something was wrong");
                    }
                }
            }
        }

        private void txtSearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            showCustomerData(customerController.customerFinder(txtSearchBox.Text));
        }
    }
}
