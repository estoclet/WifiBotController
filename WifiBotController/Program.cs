using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Threading;

namespace WifiBotController
{
    class Program
    {
        static void Main(string[] args)
        {
            Byte[] Avant = new byte[2] { 0x70, 0x70 };
            Byte[] Arriere = new byte[2] { 0x30, 0x30 };
            TcpClient SocketClient = new TcpClient();
            NetworkStream NetStream;
            int i = 0;
            try
            {
                SocketClient.Connect("localhost", 15020);
                NetStream = SocketClient.GetStream();
                NetStream.Write(Avant, 0, 2);
                Thread.Sleep(2000);
            }
            catch (SocketException e)
            {
                Console.WriteLine("Erreur à la connexion " + e);
            }
        }
    }
}
