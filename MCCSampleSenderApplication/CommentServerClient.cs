using MCC.Utility;
using MCC.Utility.IO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MCCSampleSenderApplication
{
    public class CommentServerClient
    {
        private ClientWebSocket client;
        private bool exit;
        public CommentServerClient()
        {
            client = new ClientWebSocket();
        }

        public void Connect()
        {
            Task.Run(async () =>
            {
                while (!exit)
                {
                    if (client.State == WebSocketState.None || client.State == WebSocketState.Closed || client.State == WebSocketState.Aborted)
                    {
                        if (client.State == WebSocketState.Closed || client.State == WebSocketState.Aborted)
                        {
                            client.Dispose();
                            client = new ClientWebSocket();
                        }
                        try
                        {
                            await client.ConnectAsync(new Uri("ws://localhost:29291/"), CancellationToken.None);
                        }
                        catch (Exception e)
                        {
                            Debug.WriteLine(e.Message);
                        }
                    }

                    await Task.Delay(5000);
                }
            });
        }

        public void Send(string userName, string comment)
        {
            var data = new CommentData()
            {
                LiveName = "SampleClient",
                UserName = userName,
                UserID = "sample_userid",
                Comment = comment,
                PostTime = DateTime.Now
            };

            if (client.State == WebSocketState.Open)
            {
                var response = JsonSerializer.Serialize<CommentData>(data);
                var buffer = Encoding.UTF8.GetBytes(response);
                var segment = new ArraySegment<byte>(buffer);

                client.SendAsync(segment, WebSocketMessageType.Text, true, CancellationToken.None);
            }
        }

        public void Close()
        {
            exit = true;
            if (client.State == WebSocketState.Open)
            {
                client.CloseAsync(WebSocketCloseStatus.NormalClosure, "OK", CancellationToken.None);
            }

            client.Abort();
            client.Dispose();
        }
    }
}
