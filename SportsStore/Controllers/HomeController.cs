using Microsoft.AspNetCore.Mvc;
using SportsStore.Repository;
using System.Linq;

namespace SportsStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStoreRepository _storeRepository;

        //pagination 
        public int PageSize = 4;

        public HomeController(IStoreRepository storeRepository)
        {
            _storeRepository = storeRepository;
        }
        public IActionResult Index(int productPage = 1)
         => View(
            _storeRepository.Products
            .OrderBy(p=>p.ProductID)
            .Skip(( productPage -1 ) * PageSize)
            .Take(PageSize));
    }
}