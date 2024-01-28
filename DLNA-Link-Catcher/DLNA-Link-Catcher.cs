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
        public Form1()
        {
            int srcPort = 1900;
            int dstPort = 1060;
            string broadcastAddress = IPAddress.Broadcast.ToString();
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
