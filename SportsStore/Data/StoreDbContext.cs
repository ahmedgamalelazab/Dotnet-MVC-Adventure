using Microsoft.EntityFrameworkCore;
using SportsStore.Models;

namespace SportsStore.Data {

    public class StoreDbContext : DbContext {
        public StoreDbContext(DbContextOptions<StoreDbContext>options) : base(options)
        {
            
        }

        public virtual DbSet<Product>Products {get;set;}
    } 


}