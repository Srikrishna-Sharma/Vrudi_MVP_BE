

using Microsoft.EntityFrameworkCore;
using Vrudi_MVP_BE.Repositories.DbTables;

namespace Vrudi_MVP_BE.VrDbContext
{
    public class VrudiDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public VrudiDbContext(DbContextOptions options, IConfiguration configuration) : base(options)
        {
            Configuration = configuration;

        }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server with connection string from app settings
            options.UseSqlServer(Configuration.GetConnectionString("VrudiDb"));
        }

        public DbSet<UserLogin> userLogins { get; set; }
        public DbSet<Holidays> holiday { get; set; }
        public DbSet<Employees> employee{ get; set; }
        
    }


}
