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

                switch (action)
                {
                    case 0:
                        textBox.BeginInvoke((MethodInvoker)(() => textBox.AppendText("Request to read info\n")));
                        sent = encoding.GetBytes(fileManager.ReadAllFromFile());
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

                        foreach (IceCreamPurchase s in iceCreamPurchaseList)
                        {
                            if (s.Id.Equals(row[1]))
                            {
                                if (!row[2].Equals(""))
                                {
                                    s.Name = row[2];
                                }

                                try
                                {
                                    s.Quantity = Int32.Parse(row[3]);
                                    s.Price = Int32.Parse(row[4]);
                                }
                                catch
                                { }
                            }
                        }

                        fileManager.RewriteFile(iceCreamPurchaseList);

                        textBox.BeginInvoke((MethodInvoker)(() => textBox.AppendText("File is modified\n")));
                        sent = encoding.GetBytes("Change successfully");
                        networkStream.Write(sent, 0, sent.Length);

                        break;
                    case 3:
                        textBox.BeginInvoke((MethodInvoker)(() => textBox.AppendText("Request to delete info\n")));

                        row = command.Split(' ');

                        iceCreamPurchaseList = fileManager.ReadFromFile();

                        for (int i = 0; i < iceCreamPurchaseList.Count; i++)
                        {
                            if (iceCreamPurchaseList.ElementAt(i).Id.CompareTo(Int32.Parse(row[1])) == 0)
                            {
                                iceCreamPurchaseList.Remove(iceCreamPurchaseList.ElementAt(i));
                            }
                        }

                        fileManager.RewriteFile(iceCreamPurchaseList);

                        textBox.BeginInvoke((MethodInvoker)(() => textBox.AppendText("Info is deleted\n")));

                        sent = encoding.GetBytes("Delete uccessfully");
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
