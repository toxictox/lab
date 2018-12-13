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

namespace Lab_3_server
{
    public partial class Server : Form
    {
        TcpListener listener;

        public Server()
        {
            InitializeComponent();
            richTextBox.AppendText("Press 'Start' to run server\n");
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = false;
            listener = new TcpListener(IPAddress.Any, 5555);
            listener.Start();
            Thread threadClass = new Thread(ServerThread);
            threadClass.Start();
        }

        private void Server_Load(object sender, EventArgs e)
        {

        }

        private  void ServerThread()
        {
            while (true)
            {
                Socket socket = listener.AcceptSocket();
                if (socket.Connected)
                {
                    richTextBox.BeginInvoke((MethodInvoker)(() => richTextBox.AppendText("Client is connected...\n")));
                    NetworkStream networkStream = new NetworkStream(socket);
                    ASCIIEncoding encoding = new ASCIIEncoding();

                    ThreadClass threadClass = new ThreadClass();
                    Thread thread = threadClass.Start(networkStream, this);
                }
            }
        }
    }
}
