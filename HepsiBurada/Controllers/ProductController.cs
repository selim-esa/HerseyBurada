using Data.Concrete;
using Entity;
using Microsoft.AspNetCore.Mvc;

namespace HepsiBurada.Controllers
{
    public class ProductController : Controller
    {
        private readonly DataAccessDbContext _dataAccess;
        private readonly ProductRepository _productRepository;
        Product product = new Product();
        public ProductController(DataAccessDbContext dataAccess)
        {
            _dataAccess = dataAccess; //şimdi dene
            _productRepository = new ProductRepository(_dataAccess);
        }
        [HttpGet]
        public IActionResult Index()
        {
            var products = _dataAccess.products.ToList();
            return View(products);
        }

        [HttpGet]
        public IActionResult Ayakkabi()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Kitap()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Ekle(Product product)
        {
            _dataAccess.products.Add(product);
            _dataAccess.SaveChanges();
            return View(product);
        }
    } 
}
