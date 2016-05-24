using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiccyPicKP.BO
{
    public class User
    {
        public int Id { get; protected set; }
        public string Forename { get; protected set; }
        public string Surname { get; protected set; }
        public string Email { get; protected set; }
        public string Password { get; protected set; }
        public bool IsAdmin { get; protected set; }

        public virtual List<Server> Servers { get; protected set; }

        protected User()
        {
            Servers = new List<Server>();
        }

        public User(string forename,
            string surname,
            string email,
            string password)
            : this()
        {
            Forename = forename;
            Surname = surname;
            Email = email;
            Password = password;
        }
    }
}
