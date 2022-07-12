using System.Collections.Generic;
using System.Linq;
using SportsStore.Models;

namespace SportsStore.Repository {    

    public interface IStoreRepository {

        public IQueryable<Product> Products { get; }

    } 


}