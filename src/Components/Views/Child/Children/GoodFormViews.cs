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
using WarehouseMG.src.Components.Views.Child.Children.SubChildren;
using Excel = Microsoft.Office.Interop.Excel;

namespace WarehouseMG.src.Components.Views.Child.Children
{
    public partial class GoodFormViews : Form
    {
        private GoodsForm goodsFormController;

        private GoodsFilter goodsFilter = null;

        private DBuser user = null;
        private GoodsController goodsController = null;
        public List<DBgoods> goods = null;
        public GoodFormViews(DBuser user)
        {
            InitializeComponent();
            this.user = user;
            goodsController = new GoodsController(this.user);
        }
        public GoodFormViews(DBuser user, GoodsForm f)
        {
            InitializeComponent();
            this.user = user;
            this.goodsFormController = f;
            this.goodsFilter = new GoodsFilter(this.user, this);
            goodsController = new GoodsController(this.user);
        }

        //==============================================
        public void showGoods(List<DBgoods> goods)
        {
            goodsTableView.Rows.Clear();
            int newIndex = 0;
            int totalGoods = 0;
            int totalGoodsQty = 0;
            foreach (var s in goods)
            {
                goodsTableView.Rows.Add(
                        s.ID,
                        s.barcode,
                        s.goodsName,
                        s.goodsModel,
                        s.goodsQty,
                        s.goodsDescription,
                        s.goodsDetail,
                        s.dateStored,
                        s.goodsGroups
                    );
                int newQty = Convert.ToInt32(s.goodsQty);
                if(newQty <= 0)
                {
                    goodsTableView.Rows[newIndex].Cells[4].Style.BackColor = Color.FromArgb(247, 79, 91);
                    goodsTableView.Rows[newIndex].Cells[4].Style.SelectionForeColor = Color.FromArgb(247, 79, 91);
                }
                else if(newQty > 0 && newQty <= 10)
                {
                    goodsTableView.Rows[newIndex].Cells[4].Style.BackColor = Color.Yellow;
                    goodsTableView.Rows[newIndex].Cells[4].Style.SelectionForeColor = Color.Yellow;
                }

                totalGoods++;
                totalGoodsQty += Convert.ToInt32(goodsTableView.Rows[newIndex].Cells[4].Value.ToString());

                newIndex++;
            }
            txtTotalGoods.Text = totalGoods.ToString();
            txtTotalGoodsQty.Text = totalGoodsQty.ToString(); 
        }
        //==============================================

        private void button4_Click(object sender, EventArgs e)
        {
            this.goodsFilter.ShowDialog();
        }

        private void GoodFormViews_Load(object sender, EventArgs e)
        {
            List<DBgoods> goods = this.goodsController.getAllGoods();
            this.goods = this.goodsController.getAllGoods();
            showGoods(goods);
        }

        private void txtSearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            List<DBgoods> goods = this.goodsController.goodsFinder(txtSearchBox.Text.ToString());
            showGoods(goods);
            this.goods = this.goodsController.goodsFinder(txtSearchBox.Text.ToString());
            showGoods(goods);
        }

        public void btnRefresh_Click(object sender, EventArgs e)
        {
            GoodFormViews f = new GoodFormViews(this.user, this.goodsFormController);
            this.goodsFormController.loadForm(f);
            showGoods(this.goods);
        }

        public bool btnCheck = true;
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (goodsTableView.SelectedRows.Count >= 0)
            {
                int index = goodsTableView.SelectedRows[0].Index;
                DBgoods newGoods = new DBgoods(
                        goodsTableView.Rows[index].Cells["gId"].Value.ToString(),
                        goodsTableView.Rows[index].Cells["gBarcode"].Value.ToString(),
                        goodsTableView.Rows[index].Cells["gName"].Value.ToString(),
                        goodsTableView.Rows[index].Cells["gModel"].Value.ToString(),
                        goodsTableView.Rows[index].Cells["gDesc"].Value.ToString(),
                        goodsTableView.Rows[index].Cells["gDetails"].Value.ToString(),
                        goodsTableView.Rows[index].Cells["gGroup"].Value.ToString()
                    );
                newGoods.goodsQty = goodsTableView.Rows[index].Cells["gQty"].Value.ToString();
                GoodFormAdd f = new GoodFormAdd(this.user, newGoods, this.goodsFormController);
                //this.goodsFormController.loadForm(f);
                f.ShowDialog();
            }

            //if (btnCheck)
            //{
            //    goodsTableView.ReadOnly = false;
            //    goodsTableView.Columns[0].ReadOnly = true;
            //    goodsTableView.Columns[2].ReadOnly = true;
            //    goodsTableView.Columns[3].ReadOnly = true;
            //    btnEdit.Text = "Cancel";
            //    btnCheck = false;
            //    btnEdit.Image = global::WarehouseMG.Properties.Resources.Close_20px;

            //    DataGridViewComboBoxCell dgCaomboCml = new DataGridViewComboBoxCell();
            //    //goodsTableView.CellType["dgCaomboCml"] = dgCaomboCml;
            //}
            //else
            //{
            //    goodsTableView.ReadOnly = true;
            //    btnEdit.Text = "Edit";
            //    btnCheck = true;
            //    btnEdit.Image = global::WarehouseMG.Properties.Resources.edit_20px1;

            //}

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = goodsTableView.SelectedRows[0].Index;
            string goodsId = goodsTableView.Rows[index].Cells["gId"].Value.ToString();

            DialogResult result = MessageBox.Show("Do you wanna delete this goods ?","Remove item",MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                if (this.goodsController.removeGoods(goodsId))
                {
                    List<DBgoods> goods = this.goodsController.getAllGoods();
                    this.goods = this.goodsController.getAllGoods();
                    showGoods(goods);
                }
            }
        }

        private void goodsTableView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void txtStockQtyAlert1_Click(object sender, EventArgs e)
        {
            showGoods(goodsController.goodsQtyFilter(0));
        }

        private void label1_Click(object sender, EventArgs e)
        {
            showGoods(goodsController.goodsQtyFilter(10));
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            showGoods(goodsController.goodsStandardQtyFilter(10));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Prompt the user to choose a directory and file name
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                saveFileDialog.DefaultExt = "xlsx";

                DialogResult result = saveFileDialog.ShowDialog();

                if (result != DialogResult.OK)
                    return; // User canceled the operation

                string filePath = saveFileDialog.FileName;

                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook workbook = excelApp.Workbooks.Add();
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets[1];

                // Export header row
                for (int i = 0; i < goodsTableView.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = goodsTableView.Columns[i].HeaderText;
                }

                // Export data rows
                for (int i = 0; i < goodsTableView.Rows.Count; i++)
                {
                    for (int j = 0; j < goodsTableView.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = goodsTableView.Rows[i].Cells[j].Value.ToString();
                    }
                }

                // Save the Excel file with the chosen name and directory
                workbook.SaveAs(filePath);
                workbook.Close();
                excelApp.Quit();

                MessageBox.Show($"Data exported to Excel successfully.\nFile saved at: {filePath}", "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting data to Excel: {ex.Message}", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
