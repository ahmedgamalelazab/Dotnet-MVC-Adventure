

using System.Linq;
using SportsStore.Models;
using SportsStore.Data;


namespace SportsStore.Repository {

    public class StoreRepository : IStoreRepository
    {
        private StoreDbContext _storeDbContext;
        public StoreRepository(StoreDbContext storeDbContext)
        {
            _storeDbContext = storeDbContext;
        }
        //retrieving IQueryable products because the dbset is implementing IQueryable interfce 
        public IQueryable<Product> Products => _storeDbContext.Products;
    }



}