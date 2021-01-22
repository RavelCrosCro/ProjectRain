using DiscordRPC;

namespace ProjectRain
{
    public class DiscordRpc
    {
        public static void StartDiscordRPC()
        {
            try
            {
                client = new DiscordRpcClient("ID");
                client.Initialize();
                client.SetPresence(new RichPresence
                {
                    Details = "ProjectRain v3",
                    Timestamps = Timestamps.Now,
                    Assets = new Assets
                    {
                        LargeImageKey = "1",
                        LargeImageText = "ProjectRain",

                    }
                }); ;
            }
            catch
            {
            }
        }
        public static void StopDiscordRPC()
        {
            try
            {
                DiscordRpc.client.Dispose();
            }
            catch
            {
            }
        }
        public static DiscordRpcClient client;
    }
}