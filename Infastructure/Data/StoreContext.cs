using Microsoft.EntityFrameworkCore;
using Core.Entities;

namespace Infastructure.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext>options) : base(options)
        {

        }

        public DbSet<Products>Product {get; set;}
    }
}