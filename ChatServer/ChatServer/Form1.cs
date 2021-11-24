using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ChatServer
{
    public partial class Form1 : Form
    {
        TcpListener tcpListener;
        Thread listenThread;

        struct ClientInfo
        {
            public TcpClient Tcp;
            public string Name;
        }

        public ArrayList clientList;

        delegate void SetTextCallback(string text);

        public Form1()
        {
            InitializeComponent();
            clientList = new ArrayList();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            try
            {
                tcpListener = new TcpListener(IPAddress.Any, 11000);
                listenThread = new Thread(new ThreadStart(ListenForClients));

                listenThread.Start();
                Console.WriteLine("Start Server... ");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void ListenForClients()
        {
            tcpListener.Start();
            Console.WriteLine("Listening for clients ... ");

            while (true)
            {
                TcpClient client = tcpListener.AcceptTcpClient();
                Console.WriteLine("Client connected! "+((IPEndPoint)(client.Client.RemoteEndPoint)).Address.ToString());

                ClientInfo clientInfo = new ClientInfo();
                clientInfo.Tcp = client;
                clientInfo.Name = ((IPEndPoint)(client.Client.RemoteEndPoint)).Address.ToString();
                clientList.Add(clientInfo);

                Thread clientThread = new Thread(new ParameterizedThreadStart(handleClientComm));
                clientThread.Name = clientInfo.Name;
                clientThread.Start(clientInfo);
            }
        }

        private void handleClientComm(object client)
        {
            ClientInfo tcpClient = (ClientInfo)client;
            string allClients = "";
            NetworkStream clientStream = tcpClient.Tcp.GetStream();
            ASCIIEncoding encoder = new ASCIIEncoding();

            byte[] message = new byte[4096];
            int bytesRead;

            foreach (ClientInfo clientInfo in clientList)
            {
                Console.WriteLine("Seding List");
                byte[] buffer = encoder.GetBytes("<list>" + allClients);
                TcpClient cl = clientInfo.Tcp;
                NetworkStream cs;
                try
                {
                    cs = cl.GetStream();
                }
                catch
                {
                    return;
                }
                cs.Write(buffer, 0, buffer.Length);
                cs.Flush();
            }

            while (true)
            {
                try
                {
                    bytesRead = clientStream.Read(message, 0, 4096);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    break;
                }
                String clientMessage = "" + encoder.GetString(message, 0, bytesRead);

                if (encoder.GetString(message,0,5)=="<name>")
                {
                    for (int i = 0; i < clientList.Count; i++)
                    {
                        if (((ClientInfo)clientList[i]).Name==tcpClient.Name)
                        {
                            tcpClient.Name = encoder.GetString(message, 6, bytesRead);
                        }
                    }
                }
                else
                {
                    Console.WriteLine(clientMessage);
                }

                foreach (ClientInfo clientInfo in clientList)
                {
                    byte[] buffer = encoder.GetBytes(clientInfo.Name + ": " + clientMessage);
                    TcpClient cl = clientInfo.Tcp;
                    NetworkStream cs = cl.GetStream();
                    cs.Write(buffer, 0, buffer.Length);
                    cs.Flush();
                }
                clientStream.Flush();
            }
            foreach (ClientInfo clientInfo in clientList)
            {
                if (clientInfo.Name!=tcpClient.Name)
                {
                    allClients += clientInfo.Name + ", ";
                }
            }
            foreach (ClientInfo clientInfo in clientList)
            {
                Console.WriteLine("Sending close List");
                byte[] buffer = encoder.GetBytes("<list>" + allClients);
                TcpClient cl = clientInfo.Tcp;
                NetworkStream cs;
                try
                {
                    cs = cl.GetStream();
                }
                catch
                {
                    return;
                }

                cs.Write(buffer, 0, buffer.Length);
                cs.Flush();
            }

            Console.WriteLine("client closed: " + tcpClient.Tcp.Client.RemoteEndPoint.ToString());
            tcpClient.Tcp.Close();
            clientList.Remove(tcpClient);
        }
    }
}
