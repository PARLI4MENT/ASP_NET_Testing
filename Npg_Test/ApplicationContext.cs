using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Npg_Test
{
    public class ApplicationContext : DbContext
    {
        private const string CONN_STRING = "Host=192.168.0.203;Port=5432;Database=usersdb;Username=postgres;Password=Passwd0105";
        public DbSet<User> Users { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(CONN_STRING);
        }
    }
}
