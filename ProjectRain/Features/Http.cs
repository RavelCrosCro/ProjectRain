using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRain.Features
{
    public class Http
    {
        public static async Task<string> Get(string url)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var value = await client.GetStringAsync(url);
                    client.Dispose();
                    return value;
                }
            }
            catch
            {
                return "Error Getting Value";
            }
        }

        public static async Task<string> NewsText()
        {
            try
            {
                var client = new HttpClient();
                var content = await client.GetStringAsync("https://pastebin.com/raw/HERE");
                client.Dispose();
                return content;
            }
            catch
            {
                return "Error Loading";
            }
        }
    }
}