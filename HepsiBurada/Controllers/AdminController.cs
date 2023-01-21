using Data.Concrete;
using Entity;
using Microsoft.AspNetCore.Mvc;

namespace HepsiBurada.Controllers
{
    public class AdminController : Controller
    {

        private readonly DataAccessDbContext _dataAccess;
        private readonly AdminRepository _adminRepository;
        private readonly ProductRepository _productRepository;      
        public AdminController(DataAccessDbContext dataAccess)
        {
            _dataAccess = dataAccess;
            _adminRepository = new AdminRepository();
            _productRepository = new ProductRepository(_dataAccess);
        }

        public IActionResult Admin()
        {
            return View();
        }
    
        public IActionResult Edit()
        {
            
            return View();
        }
    }

}
