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

namespace WarehouseMG.src.Components.Views.Child.Children.FormSetting
{
    public partial class PrinterSetting : Form
    {
        public SettingController settingController;
        private DBuser user;
        public PrinterSetting(DBuser user)
        {
            InitializeComponent();
            LoadPrinters();
            this.user = user;
            settingController = new SettingController(this.user);
        }

        private void PrinterSetting_Load(object sender, EventArgs e)
        {
            if(settingController.getSttStatus("PDF") == "0")
            {
                printerSelectionBox.Visible = false;
                comboBox1.SelectedIndex = 0;
            }
            if (settingController.getSttStatus("PDF") == "1")
            {
                printerSelectionBox.Visible = true;
                comboBox1.SelectedIndex = 1;
                printerComboBox.SelectedItem = settingController.getSttStatus("PINTER_DEVICES");
            }
        }
        private void InitializeComponents()
        {
            printerComboBox = new ComboBox();
            printerComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            printerComboBox.Width = 200;

            printButton = new Button();
            printButton.Text = "Print";
            printButton.Click += PrintButton_Click;

            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.Controls.Add(new Label { Text = "Select Printer: " });
            flowLayoutPanel.Controls.Add(printerComboBox);
            flowLayoutPanel.Controls.Add(printButton);

            Controls.Add(flowLayoutPanel);
        }
        private void PrintButton_Click(object sender, EventArgs e)
        {
            // Get the selected printer name
            string selectedPrinter = printerComboBox.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedPrinter))
            {
                // Here you can use the selectedPrinter to perform printing operations
                MessageBox.Show($"Printing on {selectedPrinter}", "Print Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a printer first.", "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadPrinters()
        {
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                printerComboBox.Items.Add(printer);
            }

            // Select the first printer by default
            if (printerComboBox.Items.Count > 0)
            {
                printerComboBox.SelectedIndex = 0;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                printerSelectionBox.Visible = false;
                if (!settingController.updateSttStatus("PDF","0"))
                {
                    MessageBox.Show("Error");
                }
            }
            if (comboBox1.SelectedIndex == 1)
            {
                printerSelectionBox.Visible = true;
                if (!settingController.updateSttStatus("PDF", "1"))
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void printButton_Click_1(object sender, EventArgs e)
        {
            if(printerComboBox.SelectedIndex >= 0)
            {
                string printerName = printerComboBox.SelectedItem.ToString();
                if (settingController.updateSttStatus("PINTER_DEVICES", printerName))
                {
                    MessageBox.Show("Successfully");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }
    }
}
