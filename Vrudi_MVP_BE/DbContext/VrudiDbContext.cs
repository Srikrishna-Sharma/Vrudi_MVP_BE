

using Microsoft.EntityFrameworkCore;

namespace Vrudi_MVP_BE.VrDbContext
{
    public class VrudiDbContext : DbContext
    {
        public VrudiDbContext(DbContextOptions options) : base(options)
        {

        }
    }
    
    
}
