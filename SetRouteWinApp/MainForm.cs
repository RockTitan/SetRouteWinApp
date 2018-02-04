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
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace SetRouteWinApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // 取得本機名稱
            string strHostName = Dns.GetHostName();
            // 取得本機的IpHostEntry類別實體，用這個會提示已過時
            //IPHostEntry iphostentry = Dns.GetHostByName(strHostName);

            // 取得本機的IpHostEntry類別實體，MSDN建議新的用法
            IPHostEntry iphostentry = Dns.GetHostEntry(strHostName);
            HostNameSHowlabel.Text = Dns.GetHostName();

            // 取得所有 IP 位址
            int num = 1;
            foreach (IPAddress ipaddress in iphostentry.AddressList)
            {
                if (ipaddress.AddressFamily == AddressFamily.InterNetwork)
                {
                    //IPv4ShowLabel.Text = "IP #" + num + ": " + ipaddress.ToString(); //label無法顯示陣列?
                    IPv4ShowlistBox.Items.Add("IP #" + num + ": " + ipaddress.ToString());
                    num++;
                }                    
            }
        }

        private void On_Click(object sender, EventArgs e)
        {
            // 未測試完成能把所有DNS server列出
            MessageBox.Show(GetDnsAdress().ToString());
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

        private static IPAddress GetDnsAdress()
        {
            NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface networkInterface in networkInterfaces)
            {
                if (networkInterface.OperationalStatus == OperationalStatus.Up)
                {
                    IPInterfaceProperties ipProperties = networkInterface.GetIPProperties();
                    IPAddressCollection dnsAddresses = ipProperties.DnsAddresses;

                    foreach (IPAddress dnsAdress in dnsAddresses)
                    {
                        return dnsAdress;
                    }
                }
            }

            throw new InvalidOperationException("Unable to find DNS Address");
        }
    }
}
