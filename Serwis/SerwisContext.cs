using Microsoft.EntityFrameworkCore;
using Serwis.Models;


namespace Serwis
{
    public class SerwisContext : DbContext
    {
        public SerwisContext(DbContextOptions<SerwisContext> options) : base(options)
        {
        }

        public DbSet<Company> Companys { set; get; } 
    }
}
