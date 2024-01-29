using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using Microsoft.Win32;
using System.Net.Sockets;
using System.Management;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Channels;
using System.Threading;

namespace DLNA_Link_Catcher
{
    public partial class Form1 : Form
    {
        int srcPort = 1900;
        int dstPort = 1060;

        UdpClient udpClient;
        string broadcastAddress;
        bool rendererStatus;
        byte[] data;
        IPEndPoint srcIEP;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            broadcastAddress = IPAddress.Broadcast.ToString();
            udpClient = new UdpClient();
            rendererStatus = false;
            data = Encoding.ASCII.GetBytes("Message.");
            srcIEP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), srcPort);
        }

        private void Send()
        {
            rendererStatus = true;
            udpClient.Send(data, data.Length, srcIEP);
        }

        private void Receive()
        {
            rendererStatus = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Send();
        }
    }
}
