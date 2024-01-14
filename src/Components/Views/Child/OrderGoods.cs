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
using WarehouseMG.src.Components.Controller;
using ZXing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WarehouseMG.src.Components.Views.Child
{
    public partial class OrderGoods : Form
    {
        private DBuser user;

        public SettingController settingController;

        public CategoryController categoryController;
        public GroupsGoodsController groupController;
        public GoodsController goodsController;
        public goodsLocalController goodsLocalController;
        public CustomerController customerController;
        public OrderController orderController;
        public LineItemController lineItemController;
        public UserAccountController userAccountController;

        public List<DBCategory> categories;
        public List<DBgroupsGoods> groupsGoods;
        public List<DBgoods> goods;
        public List<DBcustomers> customers;


        public OrderGoods(DBuser user)
        {
            InitializeComponent();
            this.user = user;

            settingController = new SettingController(this.user);


            categoryController = new CategoryController(this.user);
            groupController = new GroupsGoodsController(this.user);
            goodsController = new GoodsController(this.user);
            customerController = new CustomerController(this.user);
            orderController = new OrderController(this.user);
            lineItemController = new LineItemController(this.user);
            userAccountController = new UserAccountController(this.user);


            categories = categoryController.getAllCategory();
            groupsGoods = groupController.getAllGroupsGoods();
            goods = goodsController.getGoodsForOrder();
            customers = customerController.getAllCustomers();

            goodsLocalController = new goodsLocalController(goodsController.getAllGoods());

        }

        public void showGoodsData(List<DBgoods> goods)
        {
            goodsTableView.Rows.Clear();
            foreach (var s in goods)
            {
                goodsTableView.Rows.Add(
                        s.ID,
                        s.barcode,
                        s.goodsName,
                        s.goodsModel,
                        s.goodsQty
                    );
            }
        }

        private void OrderGoods_Load(object sender, EventArgs e)
        {
            foreach(var s in categoryController.getAllCategory())
            {
                listCategory.Items.Add(s.categId+"-"+s.categName);
            }
            foreach(var s in groupController.getAllGroupsGoods())
            {
                listGroups.Items.Add(s.groupsId+"-" + s.groupsName);
            }
            foreach (var s in customerController.getAllCustomers())
            {
                listCustomer.Items.Add(s.cusId + "-" + s.cusName);
            }
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    if (goodsTableView.Rows.Count > 0)
        //    {
        //        int index = goodsTableView.SelectedRows[0].Index;
        //        int qty = Convert.ToInt32(goodsTableView.Rows[index].Cells[3].Value.ToString());
        //        if (qty == 1)
        //        {
        //            for (int i = 0; i < goodsCartBox.Rows.Count; i++)
        //            {
        //                if (goodsTableView.Rows[index].Cells[0].Value.Equals(goodsCartBox.Rows[i].Cells[0].Value))
        //                {
        //                    int newQty = Convert.ToInt32(goodsCartBox.Rows[i].Cells[3].Value) + 1;
        //                    goodsCartBox.Rows[i].Cells[3].Value = newQty.ToString();

        //                    //==========================================================================
        //                    int newIndex = 0;
        //                    foreach (var s in this.goods)
        //                    {
        //                        if (goodsTableView.Rows[index].Cells[0].Value.ToString().Equals(s.barcode))
        //                        {
        //                            this.goods.RemoveAt(newIndex);
        //                            goodsLocalController.saveData(this.goods);
        //                            break;
        //                        }
        //                        newIndex++;
        //                    }
        //                    //==========================================================================
        //                    goodsTableView.Rows.RemoveAt(index);

        //                    break;
        //                }
        //            }
        //        }
        //        if (qty > 1)
        //        {
        //            if (goodsCartBox.Rows.Count >= 0)
        //            {
        //                bool check = true;
        //                for (int i = 0; i < goodsCartBox.Rows.Count; i++)
        //                {
        //                    if (goodsTableView.Rows[index].Cells[0].Value.Equals(goodsCartBox.Rows[i].Cells[0].Value))
        //                    {
        //                        int newQty = Convert.ToInt32(goodsCartBox.Rows[i].Cells[3].Value)+1;
        //                        goodsCartBox.Rows[i].Cells[3].Value = newQty.ToString();

        //                        int newQty2 = Convert.ToInt32(goodsTableView.Rows[index].Cells[3].Value) - 1;
        //                        goodsTableView.Rows[index].Cells[3].Value = newQty2.ToString();

        //                        //==========================================================================
        //                        int newIndex = 0;
        //                        foreach (var s in this.goods)
        //                        {
        //                            if (goodsTableView.Rows[index].Cells[0].Value.ToString().Equals(s.barcode))
        //                            {
        //                                this.goods[newIndex].goodsQty = newQty2.ToString();
        //                                goodsLocalController.saveData(this.goods);
        //                            }
        //                            newIndex++;
        //                        }
        //                        //==========================================================================

        //                        check = false;
        //                        break;
        //                    }
        //                }

        //                if (check)
        //                {
        //                    DBgoods goods = new DBgoods(
        //                                    goodsTableView.Rows[index].Cells[0].Value.ToString(),
        //                                    goodsTableView.Rows[index].Cells[1].Value.ToString(),
        //                                    goodsTableView.Rows[index].Cells[2].Value.ToString(),
        //                                    goodsTableView.Rows[index].Cells[3].Value.ToString()
        //                                );
        //                    goodsCartBox.Rows.Add(
        //                            goods.ID,goods.barcode, goods.goodsName, goods.goodsModel,"1"
        //                        );

        //                    int newQty2 = Convert.ToInt32(goodsTableView.Rows[index].Cells[3].Value) - 1;
        //                    goodsTableView.Rows[index].Cells[3].Value = newQty2.ToString();
        //                    //==========================================================================
        //                    int newIndex = 0;
        //                    foreach(var s in this.goods)
        //                    {
        //                        if (goodsTableView.Rows[index].Cells[0].Value.ToString().Equals(s.barcode))
        //                        {
        //                            this.goods[newIndex].goodsQty = newQty2.ToString();
        //                            goodsLocalController.saveData(this.goods);
        //                        }
        //                        newIndex++;
        //                    }
        //                    //==========================================================================
        //                }
        //            }

        //        }
        //    }

        //}

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    if (goodsTableView.Rows.Count > 0)
        //    {
        //        int index = goodsTableView.SelectedRows[0].Index;
        //        int qty = Convert.ToInt32(goodsTableView.Rows[index].Cells[3].Value.ToString());
        //        if (qty == 1)
        //        {
        //            for (int i = 0; i < goodsCartBox.Rows.Count; i++)
        //            {
        //                if (goodsTableView.Rows[index].Cells[0].Value.Equals(goodsCartBox.Rows[i].Cells[0].Value))
        //                {
        //                    int newQty = Convert.ToInt32(goodsCartBox.Rows[i].Cells[3].Value) + Convert.ToInt32(goodsTableView.Rows[index].Cells[3].Value);
        //                    goodsCartBox.Rows[i].Cells[3].Value = newQty.ToString();
        //                    //==========================================================================
        //                    int newIndex = 0;
        //                    foreach (var s in this.goods)
        //                    {
        //                        if (goodsTableView.Rows[index].Cells[0].Value.ToString().Equals(s.barcode))
        //                        {
        //                            this.goods.RemoveAt(newIndex);
        //                            goodsLocalController.saveData(this.goods);
        //                            break;
        //                        }
        //                        newIndex++;
        //                    }
        //                    //==========================================================================
        //                    goodsTableView.Rows.RemoveAt(index);
        //                    break;
        //                }
        //            }
        //        }
        //        if (qty > 1)
        //        {
        //            if (goodsCartBox.Rows.Count >= 0)
        //            {
        //                bool check = true;
        //                for (int i = 0; i < goodsCartBox.Rows.Count; i++)
        //                {
        //                    if (goodsTableView.Rows[index].Cells[0].Value.Equals(goodsCartBox.Rows[i].Cells[0].Value))
        //                    {
        //                        int newQty = Convert.ToInt32(goodsCartBox.Rows[i].Cells[3].Value) + Convert.ToInt32(goodsTableView.Rows[index].Cells[3].Value);
        //                        goodsCartBox.Rows[i].Cells[3].Value = newQty.ToString();

        //                        //==========================================================================
        //                        int newIndex = 0;
        //                        foreach (var s in this.goods)
        //                        {
        //                            if (goodsTableView.Rows[index].Cells[0].Value.ToString().Equals(s.barcode))
        //                            {
        //                                this.goods.RemoveAt(newIndex);
        //                                goodsLocalController.saveData(this.goods);
        //                                break;
        //                            }
        //                            newIndex++;
        //                        }
        //                        //==========================================================================
        //                        goodsTableView.Rows.RemoveAt(index);

        //                        check = false;
        //                        break;
        //                    }
        //                }

        //                if (check)
        //                {
        //                    DBgoods goods = new DBgoods(
        //                                    goodsTableView.Rows[index].Cells[0].Value.ToString(),
        //                                    goodsTableView.Rows[index].Cells[1].Value.ToString(),
        //                                    goodsTableView.Rows[index].Cells[2].Value.ToString(),
        //                                    goodsTableView.Rows[index].Cells[3].Value.ToString()
        //                                );
        //                    goodsCartBox.Rows.Add(
        //                            goods.ID, goods.barcode, goods.goodsName, goods.goodsModel, "1"
        //                        );
        //                    //==========================================================================
        //                    int newIndex = 0;
        //                    foreach (var s in this.goods)
        //                    {
        //                        if (goodsTableView.Rows[index].Cells[0].Value.ToString().Equals(s.barcode))
        //                        {
        //                            this.goods.RemoveAt(newIndex);
        //                            goodsLocalController.saveData(this.goods);
        //                            break;
        //                        }
        //                        newIndex++;
        //                    }
        //                    //==========================================================================
        //                    goodsTableView.Rows.RemoveAt(index);
        //                }
        //            }

        //        }
        //    }

        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    if (goodsCartBox.Rows.Count > 0)
        //    {
        //        int index = goodsCartBox.SelectedRows[0].Index;
        //        int qty = Convert.ToInt32(goodsCartBox.Rows[index].Cells[4].Value.ToString());
        //        if (qty == 1)
        //        {
        //            for (int i = 0; i < goodsTableView.Rows.Count; i++)
        //            {
        //                if (goodsCartBox.Rows[index].Cells[0].Value.Equals(goodsTableView.Rows[i].Cells[0].Value))
        //                {
        //                    int newQty = Convert.ToInt32(goodsTableView.Rows[i].Cells[4].Value) + 1;
        //                    goodsTableView.Rows[i].Cells[4].Value = newQty.ToString();
        //                    //==========================================================================
        //                    int newIndex = 0;
        //                    foreach (var s in this.goods)
        //                    {
        //                        if (goodsCartBox.Rows[index].Cells[0].Value.ToString().Equals(s.barcode))
        //                        {
        //                            DBgoods listGoods = new DBgoods();
        //                            listGoods.barcode = goodsCartBox.Rows[index].Cells[0].Value.ToString();
        //                            listGoods.goodsName = goodsCartBox.Rows[index].Cells[1].Value.ToString();
        //                            listGoods.goodsModel = goodsCartBox.Rows[index].Cells[2].Value.ToString();
        //                            listGoods.goodsQty = goodsCartBox.Rows[index].Cells[3].Value.ToString();
        //                            listGoods.goodsGroups = goodsCartBox.Rows[index].Cells[4].Value.ToString();
        //                            this.goods.Add(listGoods);
        //                            goodsLocalController.saveData(this.goods);
        //                            break;
        //                        }
        //                        newIndex++;
        //                    }
        //                    //==========================================================================
        //                    goodsCartBox.Rows.RemoveAt(index);
        //                    break;
        //                }
        //            }
        //        }
        //        if (qty > 1)
        //        {
        //            if (goodsTableView.Rows.Count >= 0)
        //            {
        //                bool check = true;
        //                for (int i = 0; i < goodsTableView.Rows.Count; i++)
        //                {
        //                    if (goodsCartBox.Rows[index].Cells[0].Value.Equals(goodsTableView.Rows[i].Cells[0].Value))
        //                    {
        //                        int newQty = Convert.ToInt32(goodsTableView.Rows[i].Cells[4].Value) + 1;
        //                        goodsTableView.Rows[i].Cells[4].Value = newQty.ToString();
        //                        int newQty2 = Convert.ToInt32(goodsCartBox.Rows[index].Cells[4].Value) - 1;
        //                        goodsCartBox.Rows[index].Cells[4].Value = newQty2.ToString();
        //                        //==========================================================================
        //                        int newIndex = 0;
        //                        foreach (var s in this.goods)
        //                        {
        //                            if (goodsTableView.Rows[index].Cells[0].Value.ToString().Equals(s.barcode))
        //                            {
        //                                this.goods[newIndex].goodsQty = newQty.ToString();
        //                                goodsLocalController.saveData(this.goods);
        //                            }
        //                            newIndex++;
        //                        }
        //                        //==========================================================================
        //                        check = false;
        //                        break;
        //                    }
        //                }

        //                if (check)
        //                {
        //                    DBgoods goods = new DBgoods(
        //                                    goodsTableView.Rows[index].Cells[0].Value.ToString(),
        //                                    goodsTableView.Rows[index].Cells[1].Value.ToString(),
        //                                    goodsTableView.Rows[index].Cells[2].Value.ToString(),
        //                                    goodsTableView.Rows[index].Cells[3].Value.ToString()
        //                                );
        //                    goodsCartBox.Rows.Add(
        //                            goods.ID, goods.barcode, goods.goodsName, goods.goodsModel, "1"
        //                        );

        //                    int newQty2 = Convert.ToInt32(goodsCartBox.Rows[index].Cells[4].Value) - 1;
        //                    goodsCartBox.Rows[index].Cells[4].Value = newQty2.ToString();
        //                    //==========================================================================
        //                    int newIndex = 0;
        //                    foreach (var s in this.goods)
        //                    {
        //                        if (goodsTableView.Rows[index].Cells[0].Value.ToString().Equals(s.barcode))
        //                        {
        //                            this.goods[newIndex].goodsQty = newQty2.ToString();
        //                            goodsLocalController.saveData(this.goods);
        //                        }
        //                        newIndex++;
        //                    }
        //                    //==========================================================================
        //                }
        //            }

        //        }
        //    }
        //}

        //private void button4_Click(object sender, EventArgs e)
        //{
        //    if (goodsCartBox.Rows.Count > 0)
        //    {
        //        int index = goodsCartBox.SelectedRows[0].Index;
        //        int qty = Convert.ToInt32(goodsCartBox.Rows[index].Cells[3].Value.ToString());
        //        if (qty == 1)
        //        {

        //        }
        //        if (qty > 1)
        //        {
        //            if (goodsTableView.Rows.Count >= 0)
        //            {
        //                bool check = true;
        //                for (int i = 0; i < goodsTableView.Rows.Count; i++)
        //                {
        //                    if (goodsCartBox.Rows[index].Cells[0].Value.Equals(goodsTableView.Rows[i].Cells[0].Value))
        //                    {
        //                        int newQty = Convert.ToInt32(goodsTableView.Rows[i].Cells[3].Value) + Convert.ToInt32(goodsCartBox.Rows[index].Cells[3].Value);
        //                        goodsTableView.Rows[i].Cells[3].Value = newQty.ToString();

        //                        //==========================================================================
        //                        int newIndex = 0;
        //                        foreach (var s in this.goods)
        //                        {
        //                            if (goodsCartBox.Rows[index].Cells[0].Value.ToString().Equals(s.barcode))
        //                            {
        //                                this.goods.RemoveAt(newIndex);
        //                                goodsLocalController.saveData(this.goods);
        //                                break;
        //                            }
        //                            newIndex++;
        //                        }
        //                        //==========================================================================
        //                        goodsCartBox.Rows.RemoveAt(index);

        //                        check = false;
        //                        break;
        //                    }
        //                }

        //                if (check)
        //                {
        //                    DBgoods goods = new DBgoods(
        //                                    goodsTableView.Rows[index].Cells[0].Value.ToString(),
        //                                    goodsTableView.Rows[index].Cells[1].Value.ToString(),
        //                                    goodsTableView.Rows[index].Cells[2].Value.ToString(),
        //                                    goodsTableView.Rows[index].Cells[3].Value.ToString()
        //                                );
        //                    goodsCartBox.Rows.Add(
        //                            goods.ID, goods.barcode, goods.goodsName, goods.goodsModel, "1"
        //                        );
        //                    //==========================================================================
        //                    int newIndex = 0;
        //                    foreach (var s in this.goods)
        //                    {
        //                        if (goodsCartBox.Rows[index].Cells[0].Value.ToString().Equals(s.barcode))
        //                        {
        //                            this.goods.RemoveAt(newIndex);
        //                            goodsLocalController.saveData(this.goods);
        //                            break;
        //                        }
        //                        newIndex++;
        //                    }
        //                    //==========================================================================
        //                    goodsCartBox.Rows.RemoveAt(index);
        //                }
        //            }

        //        }
        //    }
        //}

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (!listGroups.Text.Equals(""))
            {
                int groupsBoxIndex = listGroups.SelectedIndex;
                string groupsId = groupsGoods[groupsBoxIndex].groupsId;

                showGoodsData(goodsController.goodsGroupsIdFilter(groupsId));
            }

            if (listGroups.Text.Equals("") && !listCategory.Text.Equals(""))
            {
                
                int categBoxIndex = listCategory.SelectedIndex;
                string categId = categories[categBoxIndex].categId;

                List<DBgoods> newGoods = new List<DBgoods>();
                List<DBgroupsGoods> newGroupsGoods = new List<DBgroupsGoods>();
                newGroupsGoods = this.groupController.groupsGoodsCategoryIdFilter(categId);
                foreach (var s in newGroupsGoods)
                {
                    List<DBgoods> newGoods2 = new List<DBgoods>();
                    newGoods2 = goodsController.goodsGroupsIdFilter(s.groupsId);
                    foreach (var k in newGoods2)
                    {
                        DBgoods listGoods = new DBgoods();
                        listGoods.ID = k.ID;
                        listGoods.barcode = k.barcode;
                        listGoods.goodsName = k.goodsName;
                        listGoods.goodsModel = k.goodsModel;
                        listGoods.goodsQty = k.goodsQty;
                        listGoods.goodsGroups = k.goodsGroups;
                        newGoods.Add(listGoods);
                    }
                }

                showGoodsData(newGoods);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(listCustomer.Text != "")
            {
                if (goodsCartBox.Rows.Count > 0)
                {
                    bool checkUpdate = true;
                    DBorder dBorder = new DBorder();
                    string newCusId = listCustomer.SelectedItem.ToString();
                    string[] cusId = newCusId.Split('-');
                    dBorder.customerId = cusId[0];
                    string newUserAccountId = "";
                    foreach(var s in userAccountController.getUserAccountByUserId(this.user.Id))
                    {
                        newUserAccountId = s.Id;
                    }
                    dBorder.userId = newUserAccountId;
                    if (orderController.orderGoods(dBorder))
                    {
                        for (int i = 0; i < goodsCartBox.Rows.Count; i++)
                        {
                            DBgoods newGoods = new DBgoods();
                            newGoods.barcode = goodsCartBox.Rows[i].Cells[1].Value.ToString();
                            newGoods.goodsQty = goodsCartBox.Rows[i].Cells[4].Value.ToString();

                            DBlineItems dBlineItems = new DBlineItems();
                            dBlineItems.orderId = orderController.getOrderId().ToString();
                            dBlineItems.goodsId = goodsCartBox.Rows[i].Cells[0].Value.ToString();
                            dBlineItems.qtyOrdered = goodsCartBox.Rows[i].Cells[4].Value.ToString();
                            if (!goodsController.modifyGoodsQty(newGoods))
                            {
                                MessageBox.Show("Something was wrong !");
                                checkUpdate = false;
                                break;
                            }
                            if (!lineItemController.addLine(dBlineItems))
                            {
                                MessageBox.Show("Something was wrong !");
                                checkUpdate = false;
                                break;
                            }
                        }
                        if (checkUpdate)
                        {
                            
                            //MessageBox.Show("Order Successfully !");

                            if (settingController.getSttStatus("PDF") == "0")
                            {
                                printDocument1.DefaultPageSettings.PaperSize = new PaperSize("Custom", 300, 600);
                                printDocument1.PrinterSettings.PrinterName = "Microsoft Print to PDF";
                                printPreviewDialog1.Document = printDocument1;
                                //printDocument1.Print();
                                printPreviewDialog1.ShowDialog();
                            }
                            if (settingController.getSttStatus("PDF") == "1")
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

                            goodsCartBox.Rows.Clear();
                            btnSave_Click_1(sender, e);
                        }
                    }


                }
            }
        }

        private void listCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            listGroups.Text = "";
            listGroups.Items.Clear();

            int categBoxIndex = listCategory.SelectedIndex;
            string categId = categories[categBoxIndex].categId;
            this.groupsGoods = groupController.groupsGoodsCategoryIdFilter(categId);
            foreach (var s in groupsGoods)
            {
                listGroups.Items.Add(s.groupsId + "-" + s.groupsName);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            listCustomer.Items.Clear();
            foreach (var s in customerController.customerFinder(txtSearchBox.Text.ToString()))
            {
                listCustomer.Items.Add(s.cusId + "-" + s.cusName);
            }
        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            listCustomer.Items.Clear();
            foreach (var s in customerController.customerFinder(txtSearchBox.Text.ToString()))
            {
                listCustomer.Items.Add(s.cusId + "-" + s.cusName);
            }
        }

        bool btnCusCheck = true;
        private void button6_Click(object sender, EventArgs e)
        {
            if (btnCusCheck)
            {
                pictureBox1.Image = global::WarehouseMG.Properties.Resources.tick_box_20px;
                btnCusCheck = false;
                btnSave.Enabled = true;
                button5.Enabled = true;
            }
            else
            {
                pictureBox1.Image = global::WarehouseMG.Properties.Resources.close_window_20px;
                btnCusCheck = true;
                btnSave.Enabled = false;
                button5.Enabled = false;
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void listCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listCustomer.Text != "")
            {
                button6.Enabled = true;
            }
        }

        private void addOne_Click(object sender, EventArgs e)
        {
            if (goodsTableView.Rows.Count > 0)
            {
                int index = goodsTableView.SelectedRows[0].Index;
                DBgoods dBgoods = new DBgoods();
                dBgoods.ID = goodsTableView.Rows[index].Cells[0].Value.ToString();
                dBgoods.barcode = goodsTableView.Rows[index].Cells[1].Value.ToString();
                dBgoods.goodsName = goodsTableView.Rows[index].Cells[2].Value.ToString();
                dBgoods.goodsModel = goodsTableView.Rows[index].Cells[3].Value.ToString();
                dBgoods.goodsQty = goodsTableView.Rows[index].Cells[4].Value.ToString();

                bool checkList = true;
                for (int i = 0; i < goodsCartBox.Rows.Count; i++)
                {
                    
                    
                        if (goodsTableView.Rows[index].Cells[0].Value.ToString().Equals(goodsCartBox.Rows[i].Cells[0].Value.ToString()))
                        {
                            if (Convert.ToInt32(goodsCartBox.Rows[i].Cells[4].Value.ToString()) < Convert.ToInt32(goodsTableView.Rows[index].Cells[4].Value.ToString()))
                            {
                                int newQty = Convert.ToInt32(goodsCartBox.Rows[i].Cells[4].Value.ToString()) + 1;
                                goodsCartBox.Rows[i].Cells[4].Value = newQty + "";
                            }
                                
                            checkList = false;
                            break;
                        }
                    
                }

                if (checkList)
                {
                    if (Convert.ToInt32(goodsTableView.Rows[index].Cells[4].Value.ToString()) > 0)
                    {
                        goodsCartBox.Rows.Add(
                                            dBgoods.ID,
                                            dBgoods.barcode,
                                            dBgoods.goodsName,
                                            dBgoods.goodsModel,
                                            1
                                        );
                    }
                    
                }
                
            }
        }

        private void addAll_Click(object sender, EventArgs e)
        {
            if (goodsTableView.Rows.Count > 0)
            {
                int index = goodsTableView.SelectedRows[0].Index;
                DBgoods dBgoods = new DBgoods();
                dBgoods.ID = goodsTableView.Rows[index].Cells[0].Value.ToString();
                dBgoods.barcode = goodsTableView.Rows[index].Cells[1].Value.ToString();
                dBgoods.goodsName = goodsTableView.Rows[index].Cells[2].Value.ToString();
                dBgoods.goodsModel = goodsTableView.Rows[index].Cells[3].Value.ToString();
                dBgoods.goodsQty = goodsTableView.Rows[index].Cells[4].Value.ToString();

                bool checkList = true;
                for (int i = 0; i < goodsCartBox.Rows.Count; i++)
                {
                        if (goodsTableView.Rows[index].Cells[0].Value.ToString().Equals(goodsCartBox.Rows[i].Cells[0].Value.ToString()))
                        {
                            goodsCartBox.Rows[i].Cells[4].Value = goodsTableView.Rows[index].Cells[4].Value.ToString();
                            checkList = false;
                            break;
                        }

                }

                if (checkList)
                {
                    goodsCartBox.Rows.Add(
                                            dBgoods.ID,
                                            dBgoods.barcode,
                                            dBgoods.goodsName,
                                            dBgoods.goodsModel,
                                            goodsTableView.Rows[index].Cells[4].Value.ToString()
                                        );
                }

            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAddNumber_Click(object sender, EventArgs e)
        {
            if (goodsTableView.Rows.Count > 0)
            {
                int index = goodsTableView.SelectedRows[0].Index;
                DBgoods dBgoods = new DBgoods();
                dBgoods.ID = goodsTableView.Rows[index].Cells[0].Value.ToString();
                dBgoods.barcode = goodsTableView.Rows[index].Cells[1].Value.ToString();
                dBgoods.goodsName = goodsTableView.Rows[index].Cells[2].Value.ToString();
                dBgoods.goodsModel = goodsTableView.Rows[index].Cells[3].Value.ToString();
                dBgoods.goodsQty = goodsTableView.Rows[index].Cells[4].Value.ToString();

                bool checkList = true;
                for (int i = 0; i < goodsCartBox.Rows.Count; i++)
                {


                    if (goodsTableView.Rows[index].Cells[0].Value.ToString().Equals(goodsCartBox.Rows[i].Cells[0].Value.ToString()))
                    {
                        if (Convert.ToInt32(goodsCartBox.Rows[i].Cells[4].Value.ToString()) < Convert.ToInt32(goodsTableView.Rows[index].Cells[4].Value.ToString()))
                        {
                            int newQty = Convert.ToInt32(goodsCartBox.Rows[i].Cells[4].Value.ToString());
                            goodsCartBox.Rows[i].Cells[4].Value = newQty + Convert.ToInt32(addWithNumber.Text.ToString());
                        }

                        checkList = false;
                        break;
                    }

                }

                if (checkList)
                {
                    if (Convert.ToInt32(goodsTableView.Rows[index].Cells[4].Value.ToString()) > 0)
                    {
                        goodsCartBox.Rows.Add(
                                            dBgoods.ID,
                                            dBgoods.barcode,
                                            dBgoods.goodsName,
                                            dBgoods.goodsModel,
                                            addWithNumber.Text.ToString()
                                        );
                    }

                }

            }
        }

        private void btnBackNumber_Click(object sender, EventArgs e)
        {
            if (goodsCartBox.Rows.Count > 0)
            {
                int index = goodsCartBox.SelectedRows[0].Index;
                if (Convert.ToInt32(goodsCartBox.Rows[index].Cells[4].Value.ToString()) > 1)
                {
                    goodsCartBox.Rows[index].Cells[4].Value = Convert.ToInt32(goodsCartBox.Rows[index].Cells[4].Value.ToString()) - Convert.ToInt32(backWithNumber.Text.ToString());
                }
                else
                {
                    goodsCartBox.Rows.RemoveAt(index);
                }
            }
        }

        private void addWithNumber_ValueChanged(object sender, EventArgs e)
        {
            if (goodsTableView.Rows.Count > 0)
            {
                int index = goodsTableView.SelectedRows[0].Index;
                if (Convert.ToInt32(addWithNumber.Text.ToString()) > Convert.ToInt32(goodsTableView.Rows[index].Cells[4].Value.ToString()))
                {
                    addWithNumber.Value = Convert.ToInt32(goodsTableView.Rows[index].Cells[4].Value.ToString());
                }
            }

        }

        private void backOne_Click(object sender, EventArgs e)
        {
            if (goodsCartBox.Rows.Count > 0)
            {
                int index = goodsCartBox.SelectedRows[0].Index;
                if (Convert.ToInt32(goodsCartBox.Rows[index].Cells[4].Value.ToString()) > 1)
                {
                    goodsCartBox.Rows[index].Cells[4].Value = Convert.ToInt32(goodsCartBox.Rows[index].Cells[4].Value.ToString()) - 1;
                }
                else
                {
                    goodsCartBox.Rows.RemoveAt(index);
                }
            }
        }

        private void backAll_Click(object sender, EventArgs e)
        {
            if (goodsCartBox.Rows.Count > 0)
            {
                int index = goodsCartBox.SelectedRows[0].Index;
                goodsCartBox.Rows.RemoveAt(index);
            }
        }

        private void listGroups_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Your invoice content drawing goes here
            Graphics g = e.Graphics;
            Font font = new Font("Arial", 8);
            Font fontBold = new Font("Arial", 8, FontStyle.Bold);

            // Load an image (you can replace this with the path to your image file)
            Image image = WarehouseMG.Properties.Resources.SRU_logo1;
            Rectangle targetRectangle = new Rectangle(130, 10, 50, 50);
            g.DrawImage(image, targetRectangle);


            int xSize = 80;

            // Example content
            string invoiceHeader = "Order Invoice";
            string customerName = listCustomer.Text;
            string invoiceDate = "Date: " + DateTime.Now.ToString("MM/dd/yyyy");

            // Draw the content on the page
            g.DrawString(invoiceHeader, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new PointF(80, 60));
            g.DrawString(customerName, fontBold, Brushes.Black, new PointF(10, 15 + xSize));
            g.DrawString(invoiceDate, fontBold, Brushes.Black, new PointF(10, 35 + xSize));


            g.DrawString("Barcode".ToString(), fontBold, Brushes.Black, new PointF(10, 55 + xSize));
            g.DrawString("Goods Name", fontBold, Brushes.Black, new PointF(80, 55 + xSize));
            g.DrawString("Goods Model", fontBold, Brushes.Black, new PointF(180, 55 + xSize));
            g.DrawString("Qty", fontBold, Brushes.Black, new PointF(270, 55 + xSize));

            // Create pen.
            Pen blackPen = new Pen(Color.Black, 1);

            // Create points that define line.
            PointF point1 = new PointF(10.0F, 70.0F + xSize);
            PointF point2 = new PointF(290.0F, 70.0F + xSize);

            // Draw line to screen.
            g.DrawLine(blackPen, point1, point2);

            int x = 0;
            int totalQty = 0;

            for (int i = 0; i < goodsCartBox.Rows.Count; i++)
            {
                var data = goodsCartBox.Rows[i];
                totalQty += Convert.ToInt32(data.Cells[4].Value.ToString());

                g.DrawString(data.Cells[1].Value.ToString(), font, Brushes.Black, new PointF(10, 80 + x + xSize));
                g.DrawString(data.Cells[2].Value.ToString(), font, Brushes.Black, new PointF(80, 80 + x + xSize));
                g.DrawString(data.Cells[3].Value.ToString(), font, Brushes.Black, new PointF(180, 80 + x + xSize));
                g.DrawString(data.Cells[4].Value.ToString(), font, Brushes.Black, new PointF(270, 80 + x + xSize));

                x += 20;
            }

            // Create points that define line.
            point1 = new PointF(10.0F, 80.0F + x + xSize);
            point2 = new PointF(290.0F, 80.0F + x + xSize);
            // Draw line to screen.
            g.DrawLine(blackPen, point1, point2);

            g.DrawString("Total QTY", fontBold, Brushes.Black, new PointF(10, 90 + x + xSize));
            g.DrawString(totalQty.ToString(), fontBold, Brushes.Black, new PointF(270, 90 + x + xSize));


            // Replace "Order ID" with the actual data you want in the barcode
            string barcodeData = orderController.getOrderId().ToString();

            // Create a BarcodeWriter instance
            BarcodeWriter barcodeWriter = new BarcodeWriter();
            barcodeWriter.Format = BarcodeFormat.CODE_128; // You can choose a different format

            // Generate a barcode bitmap
            Bitmap barcodeBitmap = barcodeWriter.Write(barcodeData);

            // Display the barcode in the PictureBox
            //pictureBox1.Image = barcodeBitmap;


            g.DrawImage(barcodeBitmap, 10, 120 + x + xSize, barcodeBitmap.Width, 50);
        }
    }
}
