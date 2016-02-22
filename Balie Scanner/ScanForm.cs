using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using datalogic.datacapture;
using System.IO;

namespace BalieScanner
{
    public partial class ScanForm : Form
    {
        List<ScannedProduct> productList;
        List<string> knownProductList;
        String scannerInput;
        Laser laser;
        bool replace = false;

        public ScanForm(List<ScannedProduct> productList, List<string> knownProducts, Laser laser)
        {
            InitializeComponent();

            this.productList = productList;
            this.knownProductList = knownProducts;
            this.laser = laser;

            this.laser.GoodReadEvent += new ScannerEngine.LaserEventHandler(laser_GoodReadEvent);
            this.laser.ScannerEnabled = true;

            this.KeyDown += new KeyEventHandler(ScanForm_KeyDown);
            this.countTextBox.KeyPress += new KeyPressEventHandler(submitProductWithEnterKey);
            this.productTextBox.TextChanged += new EventHandler(ProductTextBox_TextChanged);

            productTextBox.Focus();
        }

        private void ScanForm_KeyDown(object sender, KeyEventArgs key)
        {
            String pressedKey = key.KeyCode.ToString();

            if (pressedKey == "Escape")
            {
                this.laser.ScannerEnabled = false;
                this.laser.GoodReadEvent -= laser_GoodReadEvent;

                this.KeyDown -= ScanForm_KeyDown;
                this.countTextBox.KeyPress -= submitProductWithEnterKey;
                this.productTextBox.TextChanged -= ProductTextBox_TextChanged;

                // Save the product list to file as backup
                string directory = "\\Backup\\goederenontvangst";
                StreamWriter file = new StreamWriter(directory + "\\scannerdata.txt");

                foreach (ScannedProduct product in this.productList)
                {
                    file.WriteLine(product.getProduct() + "," + product.getCount());
                }

                file.Close();

                this.Close();
                key.Handled = true;
            }
            else if (pressedKey == "Return" && this.productTextBox.Focused)
            {
                if (this.productTextBox.Text.Length == 7 || this.productTextBox.Text.Length == 8)
                {
                    this.countTextBox.Focus();
                }
                key.Handled = true;
            }
        }

        private void ProductTextBox_TextChanged(object sender, EventArgs argv)
        {
            if (this.productTextBox.Text.Length == 7 || this.productTextBox.Text.Length == 8)
            {
                this.countTextBox.Enabled = true;
            }
            else
            {
                this.countTextBox.Enabled = false;
            }
        }

        private void laser_GoodReadEvent(ScannerEngine sender)
        {
            this.scannerInput = laser.BarcodeDataAsText;

            productTextBox.Text = scannerInput;

            if (this.productList.Exists(findScannedProduct))
            {
                this.countTextBox.Text = this.productList.Find(findScannedProduct).getCount();
                this.replace = true;
            }

            if (productTextBox.Text != String.Empty)
            {
                this.countTextBox.Enabled = true;
                this.countTextBox.Focus();
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            saveProductToList();
        }

        private void saveProductToList()
        {
            if (productTextBox.Text != String.Empty && countTextBox.Text != String.Empty && this.knownProductList.Exists(isProductKnown))
            {
                if (this.replace)
                {
                    this.productList.Find(findScannedProduct).setCount(countTextBox.Text);
                    this.replace = false;
                }
                else
                {
                    ScannedProduct sp = new ScannedProduct(productTextBox.Text);
                    sp.setCount(countTextBox.Text);

                    this.productList.Add(sp);
                }

                countTextBox.Enabled = false;

                countTextBox.Text = productTextBox.Text = String.Empty;

                productTextBox.Focus();
            }
        }

        private void submitProductWithEnterKey(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                saveProductToList();
            }
        }

        private bool findScannedProduct(ScannedProduct obj)
        {
            return obj.getProduct() == this.scannerInput;
        }

        private bool isProductKnown(string product)
        {
            if (product == this.scannerInput)
            {
                return true;
            }
            else
            {
                Console.WriteLine(MessageBox.Show("Het gescande product staat niet in de lijst. Doorgaan?", "Waarschuwing",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Exclamation,
                                 MessageBoxDefaultButton.Button1));
                return false;
            }
        }
    }
}