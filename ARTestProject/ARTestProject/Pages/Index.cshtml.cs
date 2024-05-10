using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Net;
using System.Net.Sockets;

namespace ARTestProject.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public string GetIPAddress()
        {
            string hostName = Dns.GetHostName();
            return Dns.GetHostByName(hostName).AddressList[1].ToString();
        }

        public string GetIPAddresses()
        {
            string hostName = Dns.GetHostName();
            string ips = "";
            foreach(IPAddress ip in Dns.GetHostByName(hostName).AddressList)
            {
                ips = ips + "," + ip;
            }



            return ips;
        }
    }
}
