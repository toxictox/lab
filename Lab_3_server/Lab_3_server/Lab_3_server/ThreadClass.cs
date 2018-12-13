using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Windows.Forms;


namespace Lab_3_server
{
    class ThreadClass
    {
        NetworkStream networkStream;
        Server serverForm;
        ASCIIEncoding encoding;
        RichTextBox textBox;
        FileManager fileManager;
        String fileName = "D:\\Учебное\\RIS\\Lab_3_server\\Lab_3_server\\text.txt";

        public Thread Start(NetworkStream networkStream, Server form)
        {
            this.networkStream = networkStream;
            serverForm = form;
            encoding = new ASCIIEncoding();
            Control.ControlCollection controls = serverForm.Controls;
            textBox = (RichTextBox)controls.Find("richTextBox", true).ElementAt(0);

            Thread thread = new Thread(new ThreadStart(ThreadOperations));
            thread.Start();

            return thread;
        }

        public void ThreadOperations()
        {
            string[] row;
            List<IceCreamPurchase> iceCreamPurchaseList;
            String result;

            fileManager = new FileManager();

            while (true)
            {
                int buffLen = 256;
                byte[] received = new byte[buffLen];
                StringBuilder sb = new StringBuilder();
                int incomingData;
                do
                {
                    incomingData = networkStream.Read(received, 0, received.Length);
                    sb.Append(encoding.GetString(received, 0, incomingData));
                }
                while (incomingData == buffLen);

                String command = sb.ToString();

                int action = Int32.Parse(command.Substring(0, 1));
                byte[] sent = new byte[buffLen];
                IceCreamPurchase purchase = null;
                switch (action)
                {
                    case 0:
                        textBox.BeginInvoke((MethodInvoker)(() => textBox.AppendText("Request to read info\n")));
                        var dataToSend = fileManager.ReadAllFromFile();
                        if (dataToSend.Length == 0)
                            dataToSend = " ";
                        sent = encoding.GetBytes(dataToSend);
                        networkStream.Write(sent, 0, sent.Length);
                        textBox.BeginInvoke((MethodInvoker)(() => textBox.AppendText("Info is read and sent\n")));
                        break;
                    case 1:
                        textBox.BeginInvoke((MethodInvoker)(() => textBox.AppendText("Request to record info\n")));
                        String newValue = command.Trim(' ');
                        fileManager.AddToFile(newValue);
                        textBox.BeginInvoke((MethodInvoker)(() => textBox.AppendText("Info is recorded\n")));
                        sent = encoding.GetBytes("Add successfully");
                        networkStream.Write(sent, 0, sent.Length);
                        break;
                    case 2:
                        textBox.BeginInvoke((MethodInvoker)(() => textBox.AppendText("Request to edit info\n")));

                        row = command.Split(' ');

                        iceCreamPurchaseList = fileManager.ReadFromFile();

                        purchase = iceCreamPurchaseList.Find(x => x.Id == Int32.Parse(row[1]));
                        if (purchase != null)
                        {
                            purchase.Name = row[3];
                            purchase.Quantity = Int32.Parse(row[4]);
                            purchase.Price = Int32.Parse(row[5]);

                            fileManager.RewriteFile(iceCreamPurchaseList);
                            textBox.BeginInvoke((MethodInvoker)(() => textBox.AppendText("File is modified\n")));
                            sent = encoding.GetBytes("Change successfully");
                        }
                        else
                        {
                            textBox.BeginInvoke((MethodInvoker)(() => textBox.AppendText("purchase id = " + row[1] + " not found\n")));
                            sent = encoding.GetBytes("Change not successfully");
                        }

                        networkStream.Write(sent, 0, sent.Length);

                        break;
                    case 3:
                        textBox.BeginInvoke((MethodInvoker)(() => textBox.AppendText("Request to delete info\n")));

                        row = command.Split(' ');

                        iceCreamPurchaseList = fileManager.ReadFromFile();

                        purchase = iceCreamPurchaseList.Find(x => x.Id == Int32.Parse(row[1]));
                        if (purchase != null)
                        {
                            iceCreamPurchaseList.Remove(purchase);
                            fileManager.RewriteFile(iceCreamPurchaseList);
                            textBox.BeginInvoke((MethodInvoker)(() => textBox.AppendText("Info is deleted\n")));
                            sent = encoding.GetBytes("Delete uccessfully");
                        }
                        else
                        {
                            textBox.BeginInvoke((MethodInvoker)(() => textBox.AppendText("purchase id = " + row[1] + " not found\n")));
                            sent = encoding.GetBytes("Delete not successfully");
                        }


                        networkStream.Write(sent, 0, sent.Length);

                        break;
                    case 4:
                        result = "";

                        textBox.BeginInvoke((MethodInvoker)(() => textBox.AppendText("Request to sort info\n")));

                        row = command.Split(' ');
                        iceCreamPurchaseList = fileManager.ReadFromFile();
                        iceCreamPurchaseList = fileManager.Sort(iceCreamPurchaseList, row[1], row[2]);

                        for (int i = 0; i < iceCreamPurchaseList.Count(); i++)
                        {
                            result += iceCreamPurchaseList.ElementAt(i).Id + " " + iceCreamPurchaseList.ElementAt(i).Name + " " + iceCreamPurchaseList.ElementAt(i).Quantity + " " + iceCreamPurchaseList.ElementAt(i).Price + "\n";
                        }

                        sent = encoding.GetBytes(result);

                        textBox.BeginInvoke((MethodInvoker)(() => textBox.AppendText("Info is sorted\n")));
                        networkStream.Write(sent, 0, sent.Length);

                        break;
                    case 5:
                        textBox.BeginInvoke((MethodInvoker)(() => textBox.AppendText("Request to find info\n")));
                        result = "";

                        row = command.Split(' ');
                        iceCreamPurchaseList = fileManager.ReadFromFile();

                        iceCreamPurchaseList = fileManager.Find(iceCreamPurchaseList, row[1], row[2]);

                        if (iceCreamPurchaseList.Count() != 0)
                        {
                            for (int i = 0; i < iceCreamPurchaseList.Count(); i++)
                            {
                                result += iceCreamPurchaseList.ElementAt(i).Id + " " + iceCreamPurchaseList.ElementAt(i).Name + " " + iceCreamPurchaseList.ElementAt(i).Quantity + " " + iceCreamPurchaseList.ElementAt(i).Price + "\n";
                            }
                        }
                        else
                        {
                            result = "Nothing found";
                        }

                        sent = encoding.GetBytes(result);
                        textBox.BeginInvoke((MethodInvoker)(() => textBox.AppendText("File is filtered\n")));
                        networkStream.Write(sent, 0, sent.Length);

                        break;
                    case 9:
                        textBox.BeginInvoke((MethodInvoker)(() => textBox.AppendText("Client disconnected\n")));
                        return;
                }
            }
        }
    }
}
