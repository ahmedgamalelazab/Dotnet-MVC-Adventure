using Microsoft.AspNetCore.Mvc;
using SportsStore.Repository;
using System.Linq;
using SportsStore.ViewModels;

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
         => View(new ProductListViewModel {
            Products = _storeRepository.Products.OrderBy(p=>p.ProductID)
            .Skip((productPage - 1) * PageSize)
            .Take(PageSize),
            PagingInfo = new PagingInfo{
                CurrentPage = productPage,
                ItemsPerPage = PageSize,
                TotalItems = _storeRepository.Products.Count()
            }
         });
    }
}