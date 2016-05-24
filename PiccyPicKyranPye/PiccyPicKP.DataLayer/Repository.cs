using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiccyPicKP.DataLayer
{
    public class Repository : IDisposable
    {
        private DataContext context;

        public Repository()
        {
            context = new DataContext();
        }

        public void UserAdd(BO.User user)
        {
            context.Users.Add(user);
        }

        public BO.User UserGet(string email)
        {
            return context.Users.FirstOrDefault(x => x.Email == email);
        }

        public BO.User UserGet(int id)
        {
            return context.Users.FirstOrDefault(x => x.Id == id);
        }

        public void ServerAdd(BO.Server server)
        {
            context.Servers.Add(server);
        }

        public BO.Server ServerGet(int id)
        {
            return context.Servers.FirstOrDefault(x => x.Id == id);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}