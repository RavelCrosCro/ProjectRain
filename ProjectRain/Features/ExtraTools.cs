using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectRain.Features
{
    public class ExtraTools
    {
        public static async Task<string> NmapScanner(string ip)  //Common Port Scanner
        {
            if (string.IsNullOrWhiteSpace(ip) || (ip.Count(c => c == '.') != 3))
            {
                return "Invaild Host";
            }
            else
            {
                try
                {
                    var client = new HttpClient();
                    var content = await client.GetStringAsync($"https://api.hackertarget.com/nmap/?q={ip}");
                    return content;
                }
                catch
                {
                    return "API Error";
                }
            }
        }

        public static async Task<string> CustomPortScan(string ip, string port)  //Custom Port Scanner
        {
            if (string.IsNullOrWhiteSpace(ip) || string.IsNullOrWhiteSpace(port) || (ip.Count(c => c == '.') != 3))
            {
                return "Invalid host or some field are empty";
            }
            else
            {
                using (TcpClient tcpClient = new TcpClient())
                {
                    try
                    {
                        await tcpClient.ConnectAsync(ip, Convert.ToInt32(port));
                        tcpClient.Dispose();
                        return $"Port {port} is open on {ip}";
                    }
                    catch
                    {
                        tcpClient.Dispose();
                        return $"Port {port} is closed on {ip}";
                    }
                }
            }
        }

        public static async Task<string> ProxyDetector(string ip)
        {
            if (string.IsNullOrWhiteSpace(ip) || (ip.Count(c => c == '.') != 3))
            {
                return "Invaild Host";
            }
            else
            {
                using (var client = new HttpClient())
                {
                    var json = await client.GetStringAsync($"http://ip-api.com/json/{ip}?fields=66846719");
                    var result = JsonConvert.DeserializeObject<IpLocationModule>(json);
                    client.Dispose();
                    if (result.Status == "fail")
                    {
                        return $"Status: Fail\nMessage: {result.Message}\nQuery: {result.Query}";
                    }
                    else
                    {
                        return $"Query: {result.Query}\nISP: {result.Isp}\nMobile: {result.Mobile}\nProxy: {result.Proxy}\nHosting: {result.Hosting}";
                    }
                }
            }
        }
        
        public static void Ping(string ip)
        {
            string strCmdText;
            strCmdText = $"/K color 7 & mode con lines=20 cols=55 & ping {ip} -t";
            Process.Start("CMD.exe", strCmdText);
        }

        public static void TCPPing(string host, string port)
        {
            try
            {
                new Process
                {
                    StartInfo =
             {

                UseShellExecute = false,
                FileName = "paping.exe",
                Arguments = host + " -p " + port
             }

                }.Start();

            }
            catch
            {
                MessageBox.Show("Paping not found", "Project Rain", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static async Task<string> GeoLocation(string ip)
        {
            using (var client = new HttpClient())
            {
                var json = await client.GetStringAsync($"http://ip-api.com/json/{ip}?fields=66846719");
                var result = JsonConvert.DeserializeObject<IpLocationModule>(json);
                client.Dispose();
                if (result.Status == "fail")
                {
                    return $"Status: Fail\nMessage: {result.Message}\nQuery: {result.Query}";
                }
                else
                {
                    return "Continent: " + result.Continent + "\nCountry: " + result.Country + "\nCity: " + result.City + "\nAs: " + result.As + "\nOrg: " + result.Org + "\nISP: " + result.Isp + "\nTimezone: " + result.Timezone + "\nVPN: " + result.Proxy + "\nHosting: " + result.Hosting;
                }
            }
        }
    
    }
}
