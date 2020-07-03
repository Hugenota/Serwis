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
        public DbSet<Complaints> Complaints { set; get; }
        public DbSet<Customer> Customers { set; get; }
        public DbSet<Products> Products { set; get; }
        public DbSet<Employer> Employers { set; get; }
 
    }
}
