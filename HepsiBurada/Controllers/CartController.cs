using Data.Abstract;
using Data.Concrete;
using Entity;
using Microsoft.AspNetCore.Mvc;

namespace HepsiBurada.Controllers
{
    public class CartController : Controller
    {

       private readonly ICartRepository _cartRepository;

        public CartController(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            
            var carts = _cartRepository.GetAll();
            return View();
        }
        [HttpPost]
        public IActionResult Index(Cart cart)
        {
          
            var carts = _cartRepository.GetAll();
            return View(cart);
        }
       
    }
}
