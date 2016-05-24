using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiccyPicKP.DataLayer
{
    class DataContext : DbContext
    {
        public DbSet<BO.User> Users { get; set; }
        public DbSet<BO.Server> Servers { get; set; }
    }
}
