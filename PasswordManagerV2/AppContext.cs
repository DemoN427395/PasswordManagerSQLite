using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManagerV2
{
    public class AppContext : DbContext
    {
        public AppContext() : base("DefaultConnection")
        {

        }

        public DbSet<Manager> Managers { get; set; }
    }
}
