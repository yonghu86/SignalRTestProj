using Microsoft.AspNet.SignalR.Client;
using static System.Console;

namespace ClientWithSignalRDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection = new Connection("http://localhost:65309/Connections/ChatConnection");

            connection.Received += WriteLine;
            connection.Start().Wait();

            string line;
            while ((line = ReadLine()) != null)
            {
                connection.Send(line).Wait();
            }
        }
    }
}
