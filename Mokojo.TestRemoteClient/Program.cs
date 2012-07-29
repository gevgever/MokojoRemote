using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mokojo.RemoteClient.RemoteControlClient;

namespace Mokojo.TestRemoteClient
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControlClient client = new RemoteControlClient("TCP");
            client.Do(new RemoteCommand() { CommandString = "Stop TV" });
            client.Do(new RemoteCommand() { CommandString = "Start TV" });
            Console.WriteLine(client.CountPendingCommands());
            
        }
    }
}
