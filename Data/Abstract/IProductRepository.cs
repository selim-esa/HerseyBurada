using Entity;

namespace Data.Abstract;

public interface IProductRepository
{
    List<Product> GetAll();

    void Add(Product product);

    void Remove(int Id);

    void Update(Product product);
}
