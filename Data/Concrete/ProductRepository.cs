using Data.Abstract;
using Entity;

namespace Data.Concrete;

public class ProductRepository : IProductRepository
{
    private readonly DataAccessDbContext _context;
    public ProductRepository(DataAccessDbContext context)
    {
        _context = context;
    }

    public List<Product> GetAll()
    {
        return _context.products.ToList();
    }

    public void Add(Product product)
    {
        _context.Add(product);
        _context.SaveChanges();
    }

    public void Remove(int Id)
    {
        var hasProduct = _context.products.FirstOrDefault(p => p.Id == Id);
        if (hasProduct != null)
        {
            throw new Exception($"Bu id() sahip ürün bulunmamakta");
        }
        _context.products.Remove(hasProduct);
        _context.SaveChanges();
    }

    public void Update(Product product)
    {
        var hasProduct = _context.products.FirstOrDefault(product => product.Id == product.Id);
        if (hasProduct == null)
        {
            throw new Exception($"Bu id sahip ürün bulunmamakta");
        }
        hasProduct.Price = product.Price;
        hasProduct.Name = product.Name;
        hasProduct.Description = product.Description;
        _context.Update(hasProduct);
        _context.SaveChanges();
    }
}
