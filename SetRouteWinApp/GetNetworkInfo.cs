using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace SetRouteWinApp
{
    public class GetNetworkInfo
    {
        public static List<string> GetIPAdress() //取得IP Addresses
        {
            List<string> ipList = new List<string>();
            
            // 取得本機名稱
            string strHostName = Dns.GetHostName();
            // 取得本機的IpHostEntry類別實體，用這個會提示已過時
            //IPHostEntry iphostentry = Dns.GetHostByName(strHostName);

            // 取得本機的IpHostEntry類別實體，MSDN建議新的用法
            IPHostEntry iphostentry = Dns.GetHostEntry(strHostName);

            // 取得所有 IP 位址
            foreach (IPAddress ipAddress in iphostentry.AddressList)
            {
                if (ipAddress.AddressFamily == AddressFamily.InterNetwork)
                {
                    ipList.Add(ipAddress.ToString());
                }
            }
            return ipList;
        }


        public static List<IPAddress> GetDnsAdress() //取得DNS Addresses
        {
            List<IPAddress> dnsList = new List<IPAddress>();

            NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface networkInterface in networkInterfaces)
            {
                if (networkInterface.OperationalStatus == OperationalStatus.Up)
                {
                    IPInterfaceProperties ipProperties = networkInterface.GetIPProperties();
                    IPAddressCollection dnsAddresses = ipProperties.DnsAddresses;

                    foreach (IPAddress dnsAdress in dnsAddresses)
                    {
                        dnsList.Add(dnsAdress);
                    }
                }
            }

            return dnsList;

            throw new InvalidOperationException("Unable to find DNS Address");
        }
    }
}
