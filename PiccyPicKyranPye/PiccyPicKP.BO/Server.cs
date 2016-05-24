using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PiccyPicKP.BO
{
    public class Server
    {
        public int Id { get; protected set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public double MemoryGb { get; set; }
        public string IPAddress { get; set; }
        public string SerialNo { get; set; }
        public DateTime? LastPingedOn { get; protected set; }
        public string SpecFileName { get; set; }

        public virtual User User { get; protected set; }

        protected Server()
        {

        }

        public Server(string name,
            string ipAddress,
            User user)
            : this()
        {
            Name = name;
            IPAddress = ipAddress;

            User = user;
            user.Servers.Add(this);
        }
    }
}