using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse.DBClasses;
using WarehouseMG.src.Components.Contoller;
using WarehouseMG.src.Components.Controller;
using ZXing;

namespace WarehouseMG.src.Components.Views.Child
{
    public partial class FormReport : Form
    {
        public SettingController settingController;

        private DBuser user;
        private DBcustomers dBcustomers;

        private UserController userController;
        private UserAccountController userAccountController;
        private CustomerController customerController;
        private LineItemController lineItemController;

        private OrderController orderController;

        public FormReport(DBuser user)
        {
            InitializeComponent();
            this.user = user;

            settingController = new SettingController(this.user);

            this.dBcustomers = new DBcustomers();

            userController = new UserController(this.user);
            userAccountController = new UserAccountController(this.user);
            customerController = new CustomerController(this.user);
            lineItemController = new LineItemController(this.user);

            orderController = new OrderController(this.user);
        }

        public void showOrderReport(List<DBorder> dBorders)
        {
            reportTableView.Rows.Clear();
            lineTableView.Rows.Clear();
            foreach (var s in dBorders)
            {
                reportTableView.Rows.Add(
                        s.orderId,
                        s.orderDate,
                        s.customerId,
                        s.userId
                    );
            }
        }

        public void showReportLine(List<DBlineItems> dBlineItems)
        {
            lineTableView.Rows.Clear();
            foreach (var s in dBlineItems)
            {
                lineTableView.Rows.Add(
                        s.lineId,
                        s.goodsId,
                        s.qtyOrdered,
                        s.Goods.barcode,
                        s.Goods.goodsName,
                        s.Goods.goodsModel,
                        s.Goods.goodsGroups
                    );
            }
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            listCustomer.Items.Add("None");
            foreach(var s in customerController.getAllCustomers())
            {
                listCustomer.Items.Add(s.cusId+"-"+s.cusName);
            }
            listCustomer.SelectedIndex = 0;
            listUser.Items.Add("None");
            foreach(var s in userAccountController.getAllUserAccount())
            {
                listUser.Items.Add(s.Id + "-" + s.Username);
            }
            listUser.SelectedIndex = 0;
            
            if(orderController.getAllReport() != null)
            {
                showOrderReport(orderController.getAllReport());
            }

            if(reportTableView.Rows.Count > 0)
            {
                string orderId = reportTableView.SelectedRows[0].Cells[0].Value.ToString();
                showReportLine(lineItemController.getLineByOrderId(orderId));
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(listCustomer.SelectedIndex != 0 && listUser.SelectedIndex == 0)
            {
                string customer = listCustomer.SelectedItem.ToString();
                string[] newCusId = customer.Split('-');
                showOrderReport(orderController.fillReportByCustomerId(newCusId[0]));
            }
            else if(listCustomer.SelectedIndex == 0 && listUser.SelectedIndex != 0)
            {
                string user = listUser.SelectedItem.ToString();
                string[] newUserId = user.Split('-');
                showOrderReport(orderController.fillReportByUserId(newUserId[0]));
            }
            else if(listCustomer.SelectedIndex != 0 && listUser.SelectedIndex != 0)
            {
                string customer = listCustomer.SelectedItem.ToString();
                string[] newCusId = customer.Split('-');
                string user = listUser.SelectedItem.ToString();
                string[] newUserId = user.Split('-');
                showOrderReport(orderController.fillReportByUserIdAndCusId(newCusId[0],newUserId[0]));
            }
            else
            {
                showOrderReport(orderController.getAllReport());
            }
        }

        private void reportTableView_Click(object sender, EventArgs e)
        {
            string orderId = reportTableView.SelectedRows[0].Cells[0].Value.ToString();
            showReportLine(lineItemController.getLineByOrderId(orderId));
        }

        private void reportTableView_SelectionChanged(object sender, EventArgs e)
        {
            if(reportTableView.SelectedRows.Count > 0)
            {
                string orderId = reportTableView.SelectedRows[0].Cells[0].Value.ToString();
                showReportLine(lineItemController.getLineByOrderId(orderId));
            }
        }

        private void listCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listCustomer.Text != "")
            {
                btnSearch.Enabled = true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (orderController.getAllReport() != null)
            {
                showOrderReport(orderController.getAllReport());
            }
        }

        private void listUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listUser.Text != "")
            {
                btnSearch.Enabled = true;
            }
        }

        private void txtCusSearch_KeyUp(object sender, KeyEventArgs e)
        {
            listCustomer.Items.Clear();
            listCustomer.Items.Add("None");
            foreach (var s in customerController.customerFinder(txtCusSearch.Text.ToString()))
            {
                listCustomer.Items.Add(s.cusId + "-" + s.cusName);
            }
            listCustomer.SelectedIndex = 0;
        }

        private void txtUserSearch_KeyUp(object sender, KeyEventArgs e)
        {
            listUser.Items.Clear();
            listUser.Items.Add("None");
            foreach (var s in userAccountController.getUserAccountFilter(txtUserSearch.Text.ToString()))
            {
                listUser.Items.Add(s.Id + "-" + s.Username);
            }
            listUser.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(settingController.getSttStatus("PDF") == "0")
            {
                printDocument1.DefaultPageSettings.PaperSize = new PaperSize("Custom", 300, 600);
                printDocument1.PrinterSettings.PrinterName = "Microsoft Print to PDF";
                printPreviewDialog1.Document = printDocument1;
                //printDocument1.Print();
                printPreviewDialog1.ShowDialog();
            }
            if(settingController.getSttStatus("PDF") == "1")
            {
                // Replace "YourPrinterName" with the name of your printer
                string printerName = settingController.getSttStatus("PINTER_DEVICES");

                // Create a PrintDocument
                PrintDocument printDocument = printDocument1;

                // Set the printer name
                printDocument.PrinterSettings.PrinterName = printerName;

                // Print the document without showing the print dialog
                PrintController printController = new StandardPrintController();
                printDocument.PrintController = printController;
                printDocument.Print();
            }
            
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            // Your invoice content drawing goes here
            Graphics g = e.Graphics;
            Font font = new Font("Arial", 8);
            Font fontBold = new Font("Arial", 8,FontStyle.Bold);    

            // Load an image (you can replace this with the path to your image file)
            Image image = WarehouseMG.Properties.Resources.SRU_logo1;
            Rectangle targetRectangle = new Rectangle(130, 10, 50, 50);
            g.DrawImage(image, targetRectangle);


            int xSize = 80;

            // Example content
            string invoiceHeader = "Order Invoice";
            string customerName = "" ;
            foreach (var s in customerController.customerIdFilter(reportTableView.SelectedRows[0].Cells[2].Value.ToString()))
            {
                customerName = s.cusId+"-"+s.cusName;
            }
            string invoiceDate = "Date "+reportTableView.SelectedRows[0].Cells[1].Value.ToString();

            // Draw the content on the page
            g.DrawString(invoiceHeader, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new PointF(80, 60));
            g.DrawString(customerName, fontBold, Brushes.Black, new PointF(10, 15+xSize));
            g.DrawString(invoiceDate, fontBold, Brushes.Black, new PointF(10, 35+xSize));


            g.DrawString("Barcode".ToString(), fontBold, Brushes.Black, new PointF(10, 55+xSize));
            g.DrawString("Goods Name", fontBold, Brushes.Black, new PointF(80, 55+xSize));
            g.DrawString("Goods Model", fontBold, Brushes.Black, new PointF(180, 55+xSize));
            g.DrawString("Qty", fontBold, Brushes.Black, new PointF(270, 55+xSize));

            // Create pen.
            Pen blackPen = new Pen(Color.Black, 1);

            // Create points that define line.
            PointF point1 = new PointF(10.0F, 70.0F+xSize);
            PointF point2 = new PointF(290.0F, 70.0F+xSize);

            // Draw line to screen.
            g.DrawLine(blackPen, point1, point2);

            int x = 0;
            int totalQty = 0;

            for (int i = 0; i < lineTableView.Rows.Count; i++)
            {
                var data = lineTableView.Rows[i];
                totalQty += Convert.ToInt32(data.Cells[2].Value.ToString());

                g.DrawString(data.Cells[3].Value.ToString(), font, Brushes.Black, new PointF(10, 80 + x+xSize));
                g.DrawString(data.Cells[4].Value.ToString(), font, Brushes.Black, new PointF(80, 80 + x+xSize));
                g.DrawString(data.Cells[5].Value.ToString(), font, Brushes.Black, new PointF(180, 80 + x+xSize));
                g.DrawString(data.Cells[2].Value.ToString(), font, Brushes.Black, new PointF(270, 80 + x+xSize));

                x += 20;
            }

            // Create points that define line.
            point1 = new PointF(10.0F, 80.0F + x+xSize);
            point2 = new PointF(290.0F, 80.0F + x+xSize);
            // Draw line to screen.
            g.DrawLine(blackPen, point1, point2);

            g.DrawString("Total QTY", fontBold, Brushes.Black, new PointF(10, 90 + x+xSize));
            g.DrawString(totalQty.ToString(), fontBold, Brushes.Black, new PointF(270, 90 + x+xSize));


            // Replace "123456789" with the actual data you want in the barcode
            string barcodeData = reportTableView.SelectedRows[0].Cells[0].Value.ToString();

            // Create a BarcodeWriter instance
            BarcodeWriter barcodeWriter = new BarcodeWriter();
            barcodeWriter.Format = BarcodeFormat.CODE_128; // You can choose a different format

            // Generate a barcode bitmap
            Bitmap barcodeBitmap = barcodeWriter.Write(barcodeData);

            // Display the barcode in the PictureBox
            //pictureBox1.Image = barcodeBitmap;


            g.DrawImage(barcodeBitmap,10,120+x + xSize, barcodeBitmap.Width,50);
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure","Remove report",MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                if (reportTableView.Rows.Count > 0)
                {
                    if (reportTableView.SelectedRows.Count > 0)
                    {
                        string id = reportTableView.SelectedRows[0].Cells[0].Value.ToString();
                        if (orderController.removeReport(id))
                        {
                            MessageBox.Show("Delete successfully !");
                            showOrderReport(orderController.getAllReport());
                        }
                        else
                        {
                            MessageBox.Show("Something was wrong !");
                        }
                    }
                }
            }
        }
    }
}
