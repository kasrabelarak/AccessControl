using AccessControl.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AccessControl.EF
{
    public class DemoContext : DbContext
    {
        

        public DemoContext(DbContextOptions<DemoContext> dbContextOptions) : base(dbContextOptions)
        {

           
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

        }

        public DbSet<Staff> Tb_Staff { get; set; }


        public override int SaveChanges()
        {
            
            return base.SaveChanges();
        }

    }
}