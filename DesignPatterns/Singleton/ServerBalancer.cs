using System;
using System.Collections.Generic;

namespace Singleton
{
    public class ServerBalancer
    {
        private static  ServerBalancer Instance { get; } = new ServerBalancer();
        private List<Server> Servers { get; }
        private Random Random { get; } = new Random();

        public ServerBalancer()
        {
               Servers = new List<Server>()
               {
                   new Server(){ Name = "Server 1", IP = "10.0.2.20"},
                   new Server(){ Name = "Server 2", IP = "10.0.2.21"},
                   new Server(){ Name = "Server 3", IP = "10.0.2.22"},
                   new Server(){ Name = "Server 4", IP = "10.0.2.23"}
               };
        }
        public static ServerBalancer GetServerBalancer()
        {
            return Instance;
        }
        public Server NextServer => Servers[Random.Next(Servers.Count)];
    }
}
