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

namespace SetRouteWinApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public static List<string> GetIPAdress;
        public static List<IPAddress> GetDnsAdress;

        private void MainForm_Load(object sender, EventArgs e)
        {
            // 把所有IP列出
            GetIPAdress = GetNetworkInfo.GetIPAdress();
            int num = 1;
            foreach (var ip in GetIPAdress) {IPv4ShowlistBox.Items.Add("IP #" + num++ +": " + ip);}

            // 把所有DNS server列出
            DNSServerShowlistBox.Items.Clear();
            GetDnsAdress = GetNetworkInfo.GetDnsAdress();
            foreach (var dns in GetDnsAdress) {DNSServerShowlistBox.Items.Add(dns);}
        }

        private void On_Click(object sender, EventArgs e)
        {
            
        }

        private void SetDNS_Click(object sender, EventArgs e)
        {

        }

        private void Off_Click(object sender, EventArgs e)
        {

        }

        private void RestoreDNS_Click(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void IPv4ShowLabel_Click(object sender, EventArgs e)
        {

        }

        private void HostNameSHowlabel_Click(object sender, EventArgs e)
        {
            
        }

        private void IPv4ShowlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
