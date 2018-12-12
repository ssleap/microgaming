using Fleck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSockets.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            // 클라이언트를 리스트에 저장.
            var clients = new List<IWebSocketConnection>();

            // 서버 연결설정 초기화
            var server = new WebSocketServer("ws://localhost:1818");

            server.Start(socket =>
            {
                socket.OnOpen = () =>
                {
                    // Add the incoming connection to our list.
                    clients.Add(socket);

                    // Inform the others that someone has just joined the conversation.
                    foreach (var client in clients)
                    {
                        // Check the connection unique ID and display a different welcome message!
                        if (client.ConnectionInfo.Id != socket.ConnectionInfo.Id)
                        {
                            client.Send("<i>" + socket.ConnectionInfo.Id + " joined the conversation.</i>");
                        }
                        else
                        {
                            client.Send("<i>You have just joined the conversation.</i>");
                        }
                    }
                };

                socket.OnClose = () =>
                {
                    // Remove the disconnected client from the list.
                    clients.Remove(socket);

                    // Inform the others that someone left the conversation.
                    foreach (var client in clients)
                    {
                        if (client.ConnectionInfo.Id != socket.ConnectionInfo.Id)
                        {
                            client.Send("<i>" + socket.ConnectionInfo.Id + " left the chat room.</i>");
                        }
                    }
                };

                socket.OnMessage = message =>
                {
                    // Send the message to everyone!
                    // Also, send the client connection’s unique identifier in order to recognize who is who.
                    foreach (var client in clients)
                    {
                        client.Send(socket.ConnectionInfo.Id + " says: <strong>" + message + "</strong>");
                    }
                };
            });

            // Wait for a key press to close...
            Console.ReadLine();
        }
    }
}