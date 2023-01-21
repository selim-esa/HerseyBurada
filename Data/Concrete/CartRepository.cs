using Data.Abstract;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Concrete
{
    public class CartRepository:ICartRepository
    {
        private readonly DataAccessDbContext _context;

        public CartRepository(DataAccessDbContext context)
        {
            _context = context;
        }

        public List<Cart> GetAll()
        {
            return _context.carts.ToList();
        }


        public void Add(Cart cart)
        {
            _context.Add(cart);
            _context.SaveChanges();
        }

        public void Remove(int Id)
        {
            var hasProduct = _context.carts.FirstOrDefault(p => p.Id == Id);
            if (hasProduct != null)
            {
                throw new Exception($"Bu id() sahip ürün bulunmamakta");
            }
            _context.carts.Remove(hasProduct);
        }

        public void Update(Cart cart)
        {
            var hasProduct = _context.carts.FirstOrDefault(product => product.Id == product.Id);
            if (hasProduct == null)
            {
                throw new Exception($"Bu id sahip ürün bulunmamakta");
            }
            hasProduct.Price = cart.Price;
            hasProduct.Name = cart.Name;
            hasProduct.Description = cart.Description;
           
        }
    }
}
