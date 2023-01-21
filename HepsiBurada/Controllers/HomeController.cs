using Data.Abstract;
using Entity;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace HepsiBurada.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;

        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
           var products = _productRepository.GetAll();
            return View(products);
        }
        [HttpPost]
        public IActionResult Index(Product product)
        {
            var products = _productRepository.GetAll();
            return View(products);
        }
        [HttpGet]
        public IActionResult Cart()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cart(Product product)
        {    
            var products = _productRepository.GetAll();

            return View(products);
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            _productRepository.products.Add(user);
            _productRepository.SaveChanges();
            return View(user);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(User user)
        {
            return View();
        }

    }
}
