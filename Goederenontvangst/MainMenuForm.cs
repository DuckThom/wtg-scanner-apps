using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Goederenontvangst
{
    public partial class MainMenuForm : Form
    {
        // The global list with the scanned products
        public List<ScannedProduct> productList = new List<ScannedProduct>();

        public MainMenuForm()
        {
            InitializeComponent();

            // Bind the KeyDown event handler
            this.KeyDown += new KeyEventHandler(MainMenuForm_KeyDown);
        }

        /**
         * Handle KeyDown events
         */
        private void MainMenuForm_KeyDown(object sender, KeyEventArgs key)
        {
            String pressedKey = key.KeyCode.ToString();

            if (pressedKey == "D1")
            { // Scan
                showScanForm();
            }
            else if (pressedKey == "D2")
            { // Edit
                
            }
            else if (pressedKey == "D3")
            { // Send
                showSendForm();
            } 
            else if (pressedKey == "Escape")
            { // Close
                closeApp();
            }
        }

        /**
         * Touch the Scan button
         */
        private void scanButton_Click(object sender, EventArgs e)
        {
            showScanForm();
        }

        /**
         * Touch the Send button
         */
        private void sendButton_Click(object sender, EventArgs e)
        {
            showSendForm();
        }  

        /**
         * Touch the exit button
         */
        private void exitButton_Click(object sender, EventArgs e)
        {
            closeApp();
        }

        /**
         * Show the Scan form
         */
        private void showScanForm()
        {
            ScanForm scanform = new ScanForm(this.productList);
            scanform.Show();
        }

        /**
         * Show the Send form
         */
        private void showSendForm()
        {
            if (productList.Count > 0)
            {
                SendForm sendform = new SendForm(this.productList);
                sendform.Show();
            }
            else
            {
                MessageBeep();
            }
        }

        /**
         * Close the app
         */
        private void closeApp()
        {
            this.Close();
        }

        /**
         * Do some beeps and boops
         * (Doesn't seem to work :( )
         */
        [DllImport("CoreDll.dll")]
        public static extern void MessageBeep(int code);
        public static void MessageBeep()
        {
            MessageBeep(-1);  // Default beep code is -1
        } 
    }
}