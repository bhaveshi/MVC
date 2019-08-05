using DomainLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ECFCDb : DbContext
    {
        public ECFCDb() : base("ECFC") {}

        public DbSet<User> Users { get; set; }

        public DbSet<Roles> Roles { get; set; }

    }
}
