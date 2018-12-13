using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace Lab_3_client
{
    public partial class Client : Form
    {
        TcpClient tcpClient;
        ASCIIEncoding encoding;
        int operation;
        int sortType;
        FormManager formManager;

        public Client()
        {
            InitializeComponent();

            tcpClient = new TcpClient("localhost", 5555);
            encoding = new ASCIIEncoding();
            formManager = new FormManager();
        }

        private void radioView_CheckedChanged(object sender, EventArgs e)
        {
            operation = 0;
            purchaseGroupBox.Enabled = false;
            sortGroupBox.Enabled = false;
        }

        private void radioAdd_CheckedChanged(object sender, EventArgs e)
        {
            operation = 1;
            purchaseGroupBox.Enabled = true;
            sortGroupBox.Enabled = false;
            oldPurchaseName.Enabled = false;
            purchaseName.Enabled = true;
            quantity.Enabled = true;
            price.Enabled = true;
            purchaseId.Enabled = true;
        }

        private void radioChange_CheckedChanged(object sender, EventArgs e)
        {
            operation = 2;
            purchaseGroupBox.Enabled = true;
            sortGroupBox.Enabled = false;
            oldPurchaseName.Enabled = true;
            purchaseName.Enabled = true;
            quantity.Enabled = true;
            price.Enabled = true;
            purchaseId.Enabled = true;
        }

        private void radioDelete_CheckedChanged(object sender, EventArgs e)
        {
            operation = 3;
            purchaseGroupBox.Enabled = true;
            sortGroupBox.Enabled = false;
            oldPurchaseName.Enabled = false;
            quantity.Enabled = false;
            price.Enabled = false;
            purchaseName.Enabled = false;
            purchaseId.Enabled = true;
        }

        private void radioSort_CheckedChanged(object sender, EventArgs e)
        {
            operation = 4;
            purchaseGroupBox.Enabled = false;
            sortGroupBox.Enabled = true;
            sortOrder.Enabled = true;
        }

        private void radioFind_CheckedChanged(object sender, EventArgs e)
        {
            operation = 5;
            purchaseGroupBox.Enabled = true;
            sortGroupBox.Enabled = true;
            oldPurchaseName.Enabled = false;
            sortOrder.Enabled = false;
        }

        private void radioId_CheckedChanged(object sender, EventArgs e)
        {
            sortType = 0;
            purchaseId.Enabled = true;
            oldPurchaseName.Enabled = false;
            quantity.Enabled = false;
            price.Enabled = false;
            purchaseName.Enabled = false;
        }

        private void radioName_CheckedChanged(object sender, EventArgs e)
        {
            sortType = 1;
            oldPurchaseName.Enabled = false;
            quantity.Enabled = false;
            price.Enabled = false;
            purchaseName.Enabled = true;
            purchaseId.Enabled = false;
        }

        private void radioQuantity_CheckedChanged(object sender, EventArgs e)
        {
            sortType = 2;
            oldPurchaseName.Enabled = false;
            quantity.Enabled = true;
            price.Enabled = false;
            purchaseName.Enabled = false;
            purchaseId.Enabled = false;
        }

        private void radioPrice_CheckedChanged(object sender, EventArgs e)
        {
            sortType = 3;
            oldPurchaseName.Enabled = false;
            quantity.Enabled = false;
            price.Enabled = true;
            purchaseName.Enabled = false;
            purchaseId.Enabled = false;
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            NetworkStream networkStream = tcpClient.GetStream();
            String command = operation.ToString();
            byte[] sent = null;
            int buffLen = 256;
            byte[] received = new byte[buffLen];

            switch (operation)
            {
                case 0:
                    logListBox.Items.Add("Read info");
                    formManager.Error = "";
                    break;
                case 1:
                    logListBox.Items.Add("Add purchase");
                    command += formManager.FormAddMessage(purchaseId.Text, purchaseName.Text, quantity.Text, price.Text);
                    break;
                case 2:
                    logListBox.Items.Add("Edit purchase");
                    command += formManager.FormChangeMessage(purchaseId.Text, purchaseName.Text, quantity.Text, price.Text);
                    break;
                case 3:
                    logListBox.Items.Add("Delete purchase");
                    command += formManager.FormDeleteMessage(purchaseId.Text);
                    break;
                case 4:
                    logListBox.Items.Add("Sort list of purchases");
                    formManager.Error = "";
                    command += " " + sortType + " " + sortOrder.Checked;
                    break;
                case 5:
                    logListBox.Items.Add("Search");
                    command += formManager.FormFindMessage(purchaseId.Text, purchaseName.Text, quantity.Text, price.Text, sortType);
                    break;
            }

            if (formManager.Error.Equals(""))
            {
                sent = encoding.GetBytes(command);
                networkStream.Write(sent, 0, sent.Length);

                StringBuilder sb = new StringBuilder();
                int incomingData;
                do
                {
                    incomingData = networkStream.Read(received, 0, received.Length);
                    sb.Append(encoding.GetString(received, 0, incomingData));
                }
                while (incomingData == buffLen);

                icecreamRichTextBox.Text = sb.ToString();
            }
            else
            {
                logListBox.Items.Add(formManager.Error);
            }
        }
    }
}
