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
            // 클라이언트를 리스트에 저장, 연결.
            var clients = new List<IWebSocketConnection>();

            // 서버 연결설정 초기화
            var server = new WebSocketServer("ws://localhost:7777");

            server.Start(socket =>
            {
                socket.OnOpen = () =>
                {
                    // 리스트에 연결 추가
                    clients.Add(socket);

                    // 다른 클라이언트에 신규 참여 통지
                    foreach (var client in clients)
                    {
                        // 고유 ID 표기
                        if (client.ConnectionInfo.Id != socket.ConnectionInfo.Id)
                        {
                            client.Send("<i>" + socket.ConnectionInfo.Id + " 접속</i>");
                        }
                        else
                        {
                            client.Send("<i>접속 되었습니다.</i>");
                        }
                    }
                };

                socket.OnClose = () =>
                {
                    // 클라이언트 삭제
                    clients.Remove(socket);

                    // ID를 가진 사용자가 나갔음
                    foreach (var client in clients)
                    {
                        if (client.ConnectionInfo.Id != socket.ConnectionInfo.Id)
                        {
                            client.Send("<i>" + socket.ConnectionInfo.Id + " 가 접속을 끊었습니다.</i>");
                        }
                    }
                };

                socket.OnMessage = message =>
                {
                    // 커맨드 서버로 전송, ID 포함
                    
                    foreach (var client in clients)
                    {
                        client.Send(socket.ConnectionInfo.Id + " says: <strong>" + message + "</strong>");
                    }
                };
            });

            // 종료 대기
            Console.ReadLine();
        }
    }
}
